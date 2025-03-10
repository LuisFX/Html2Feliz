namespace FSharp.Data

open System
open Fable.IO
open System.ComponentModel
open System.Text
open System.Text.RegularExpressions
open FSharp.Data

// --------------------------------------------------------------------------------------

/// <summary>Represents an HTML attribute. The name is always normalized to lowercase</summary>
/// <namespacedoc>
///   <summary>Contains the primary types for the FSharp.Data package.</summary>
/// </namespacedoc>
///
type HtmlAttribute =

    internal
    | HtmlAttribute of name: string * value: string

    /// <summary>
    /// Creates an html attribute
    /// </summary>
    /// <param name="name">The name of the attribute</param>
    /// <param name="value">The value of the attribute</param>
    static member New(name: string, value: string) =
        HtmlAttribute(name.ToLowerInvariant(), value)

/// Represents an HTML node. The names of elements are always normalized to lowercase
[<StructuredFormatDisplay("{_Print}")>]
type HtmlNode =

    internal
    | HtmlElement of name: string * attributes: HtmlAttribute list * elements: HtmlNode list
    | HtmlText of content: string
    | HtmlComment of content: string
    | HtmlCData of content: string

    /// <summary>
    /// Creates an html element
    /// </summary>
    /// <param name="name">The name of the element</param>
    static member NewElement(name: string) =
        HtmlElement(name.ToLowerInvariant(), [], [])

    /// <summary>
    /// Creates an html element
    /// </summary>
    /// <param name="name">The name of the element</param>
    /// <param name="attrs">The HtmlAttribute(s) of the element</param>
    static member NewElement(name: string, attrs: seq<_>) =
        let attrs = attrs |> Seq.map HtmlAttribute.New |> Seq.toList

        HtmlElement(name.ToLowerInvariant(), attrs, [])

    /// <summary>
    /// Creates an html element
    /// </summary>
    /// <param name="name">The name of the element</param>
    /// <param name="children">The children elements of this element</param>
    static member NewElement(name: string, children: seq<_>) =
        HtmlElement(name.ToLowerInvariant(), [], List.ofSeq children)


    /// <summary>
    /// Creates an html element
    /// </summary>
    /// <param name="name">The name of the element</param>
    /// <param name="attrs">The HtmlAttribute(s) of the element</param>
    /// <param name="children">The children elements of this element</param>
    static member NewElement(name: string, attrs: seq<_>, children: seq<_>) =
        let attrs = attrs |> Seq.map HtmlAttribute.New |> Seq.toList

        HtmlElement(name.ToLowerInvariant(), attrs, List.ofSeq children)

    /// <summary>
    /// Creates a text content element
    /// </summary>
    /// <param name="content">The actual content</param>
    static member NewText content = HtmlText(content)

    /// <summary>
    /// Creates a comment element
    /// </summary>
    /// <param name="content">The actual content</param>
    static member NewComment content = HtmlComment(content)

    /// <summary>
    /// Creates a CData element
    /// </summary>
    /// <param name="content">The actual content</param>
    static member NewCData content = HtmlCData(content)

    override x.ToString() =
        let rec serialize (sb: StringBuilder) indentation canAddNewLine html =
            let append (str: string) = sb.Append str |> ignore

            let appendEndTag name =
                append "</"
                append name
                append ">"

            let shouldAppendEndTag name = name = "textarea"

            let newLine plus =
                sb.AppendLine() |> ignore
                String(' ', indentation + plus) |> append

            match html with
            | HtmlElement (name, attributes, elements) ->
                let onlyText =
                    elements
                    |> List.forall (function
                        | HtmlText _ -> true
                        | _ -> false)

                if canAddNewLine && not onlyText then
                    newLine 0

                append "<"
                append name

                for HtmlAttribute (name, value) in attributes do
                    append " "
                    append name
                    append "=\""
                    append value
                    append "\""

                if elements.IsEmpty then
                    if shouldAppendEndTag name then
                        append ">"
                        appendEndTag name
                    else
                        append " />"
                else
                    append ">"
                    if not onlyText then newLine 2
                    let mutable canAddNewLine = false

                    for element in elements do
                        serialize sb (indentation + 2) canAddNewLine element
                        canAddNewLine <- true

                    if not onlyText then newLine 0
                    appendEndTag name
            | HtmlText str -> append str
            | HtmlComment str ->
                append "<!--"
                append str
                append "-->"
            | HtmlCData str ->
                append "<![CDATA["
                append str
                append "]]>"

        let sb = StringBuilder()
        serialize sb 0 false x |> ignore
        sb.ToString()

    /// <exclude />
    [<EditorBrowsableAttribute(EditorBrowsableState.Never)>]
    [<CompilerMessageAttribute("This method is intended for use in generated code only.",
                               10001,
                               IsHidden = true,
                               IsError = false)>]
    member x._Print =
        let str = x.ToString()

        if str.Length > 512 then
            str.Substring(0, 509) + "..."
        else
            str

[<StructuredFormatDisplay("{_Print}")>]
type HtmlDocument =
    internal
    | HtmlDocument of docType: string * elements: HtmlNode list

    /// <summary>
    /// Creates an html document
    /// </summary>
    /// <param name="docType">The document type specifier string</param>
    /// <param name="children">The child elements of this document</param>
    static member New(docType, children: seq<_>) =
        HtmlDocument(docType, List.ofSeq children)

    /// <summary>
    /// Creates an html document
    /// </summary>
    /// <param name="children">The child elements of this document</param>
    static member New(children: seq<_>) = HtmlDocument("", List.ofSeq children)

    override x.ToString() =
        match x with
        | HtmlDocument (docType, elements) ->
            (if String.IsNullOrEmpty docType then
                 ""
             else
                 "<!DOCTYPE " + docType + ">" + Environment.NewLine)
            + (elements
               |> List.map (fun x -> x.ToString())
               |> String.Concat)

    /// <exclude />
    [<EditorBrowsableAttribute(EditorBrowsableState.Never)>]
    [<CompilerMessageAttribute("This method is intended for use in generated code only.",
                               10001,
                               IsHidden = true,
                               IsError = false)>]
    member x._Print =
        let str = x.ToString()

        if str.Length > 512 then
            str.Substring(0, 509) + "..."
        else
            str


// --------------------------------------------------------------------------------------

module TextParser =

    let toPattern f c = if f c then Some c else None

    let (|EndOfFile|_|) (c: char) =
        let value = c |> int

        if (value = -1 || value = 65535) then
            Some c
        else
            None

    let (|Whitespace|_|) = toPattern Char.IsWhiteSpace
    let (|LetterDigit|_|) = toPattern Char.IsLetterOrDigit
    let (|Letter|_|) = toPattern Char.IsLetter

// --------------------------------------------------------------------------------------

module HtmlParser =

    let wsRegex = lazy (Regex("\\s+"))

    let invalidTypeNameRegex = lazy (Regex("[^0-9a-zA-Z_]+"))

    let headingRegex = lazy (Regex("""h\d"""))

    type HtmlToken =
        | DocType of string
        | Tag of isSelfClosing: bool * name: string * attrs: HtmlAttribute list
        | TagEnd of string
        | Text of string
        | Comment of string
        | CData of string
        | EOF
        override x.ToString() =
            match x with
            | DocType dt -> sprintf "doctype %s" dt
            | Tag (selfClose, name, _) -> sprintf "tag %b %s" selfClose name
            | TagEnd name -> sprintf "tagEnd %s" name
            | Text _ -> "text"
            | Comment _ -> "comment"
            | EOF -> "eof"
            | CData _ -> "cdata"

        member x.IsEndTag name =
            match x with
            | TagEnd (endName) when name = endName -> true
            | _ -> false

    type CharList =
        { mutable Contents: char list }
        static member Empty = { Contents = [] }

        override x.ToString() =
            String(x.Contents |> List.rev |> List.toArray)

        member x.Cons(c) = x.Contents <- c :: x.Contents
        member x.Length = x.Contents.Length
        member x.Clear() = x.Contents <- []

    type InsertionMode =
        | DefaultMode
        | FormattedMode
        | ScriptMode
        | CharRefMode
        | CommentMode
        | DocTypeMode
        | CDATAMode
        override x.ToString() =
            match x with
            | DefaultMode -> "default"
            | FormattedMode -> "formatted"
            | ScriptMode -> "script"
            | CharRefMode -> "charref"
            | CommentMode -> "comment"
            | DocTypeMode -> "doctype"
            | CDATAMode -> "cdata"

    type HtmlState =
        { Attributes: (CharList * CharList) list ref
          CurrentTag: CharList ref
          Content: CharList ref
          InsertionMode: InsertionMode ref
          Tokens: HtmlToken list ref
          Reader: StringReader }
        static member Create(reader: StringReader) =
            { Attributes = ref []
              CurrentTag = ref CharList.Empty
              Content = ref CharList.Empty
              InsertionMode = ref DefaultMode
              Tokens = ref []
              Reader = reader }

        member x.Pop() = x.Reader.ReadChar() |> ignore
        member x.Peek() = x.Reader.PeekChar()

        member x.Pop(count) =
            [| 0 .. (count - 1) |]
            |> Array.map (fun _ -> x.Reader.ReadChar())

        member x.Contents = (x.Content.Value).ToString()
        member x.ContentLength = (x.Content.Value).Length

        member x.NewAttribute() =
            x.Attributes.Value <-
                (CharList.Empty, CharList.Empty)
                :: (x.Attributes.Value)

        member x.ConsAttrName() =
            match x.Attributes.Value with
            | [] ->
                x.NewAttribute()
                x.ConsAttrName()
            | (h, _) :: _ -> h.Cons(Char.ToLowerInvariant(x.Reader.ReadChar()))

        member x.CurrentTagName() = (x.CurrentTag.Value).ToString().Trim()

        member x.CurrentAttrName() =
            match x.Attributes.Value with
            | [] -> String.Empty
            | (h, _) :: _ -> h.ToString()

        member x.ConsAttrValue(c) =
            match x.Attributes.Value with
            | [] ->
                x.NewAttribute()
                x.ConsAttrValue(c)
            | (_, h) :: _ -> h.Cons(c)

        member x.ConsAttrValue() = x.ConsAttrValue(x.Reader.ReadChar())

        member x.GetAttributes() =
            x.Attributes.Value
            |> List.choose (fun (key, value) ->
                if key.Length > 0 then
                    Some
                    <| HtmlAttribute(key.ToString(), value.ToString())
                else
                    None)
            |> List.rev

        member x.EmitSelfClosingTag() =
            let name = (x.CurrentTag.Value).ToString().Trim()
            let result = Tag(true, name, x.GetAttributes())
            x.CurrentTag.Value <- CharList.Empty
            x.InsertionMode.Value <- DefaultMode
            x.Attributes.Value <- []
            x.Tokens.Value <- result :: x.Tokens.Value

        member x.IsFormattedTag =
            match x.CurrentTagName() with
            | "pre"
            | "code" -> true
            | _ -> false

        member x.IsScriptTag =
            match x.CurrentTagName().Trim().ToLower() with
            | "script"
            | "style" -> true
            | _ -> false

        member x.EmitTag(isEnd) =
            let name = (x.CurrentTag.Value).ToString().Trim()

            let result =
                if isEnd then
                    if x.ContentLength > 0 then
                        x.Emit()
                        TagEnd(name)
                    else
                        TagEnd(name)
                else
                    Tag(false, name, x.GetAttributes())

            x.InsertionMode.Value <-
                if x.IsFormattedTag && (not isEnd) then
                    FormattedMode
                elif x.IsScriptTag && (not isEnd) then
                    ScriptMode
                else
                    DefaultMode

            x.CurrentTag.Value <- CharList.Empty
            x.Attributes.Value <- []
            x.Tokens.Value <- result :: x.Tokens.Value

        member x.EmitToAttributeValue() =
            assert (x.InsertionMode.Value = InsertionMode.CharRefMode)

            let content =
                (x.Content.Value).ToString()
                |> HtmlCharRefs.substitute

            for c in content.ToCharArray() do
                x.ConsAttrValue c

            x.Content.Value <- CharList.Empty
            x.InsertionMode.Value <- DefaultMode

        member x.Emit() : unit =
            let result =
                let content = (x.Content.Value).ToString()

                match x.InsertionMode.Value with
                | DefaultMode ->
                    let normalizedContent = wsRegex.Value.Replace(content, " ")

                    if normalizedContent = " " then
                        Text ""
                    else
                        Text normalizedContent
                | FormattedMode -> content |> Text
                | ScriptMode -> content |> Text
                | CharRefMode -> content.Trim() |> HtmlCharRefs.substitute |> Text
                | CommentMode -> Comment content
                | DocTypeMode -> DocType content
                | CDATAMode ->
                    CData(
                        content
                            .Replace("<![CDATA[", "")
                            .Replace("]]>", "")
                    )

            x.Content.Value <- CharList.Empty
            x.InsertionMode.Value <- DefaultMode

            match result with
            | Text t when String.IsNullOrEmpty(t) -> ()
            | _ -> x.Tokens.Value <- result :: x.Tokens.Value

        member x.Cons() =
            (x.Content.Value).Cons(x.Reader.ReadChar())

        member x.Cons(char) = (x.Content.Value).Cons(char)

        member x.Cons(char) =
            Array.iter ((x.Content.Value).Cons) char

        member x.Cons(char: string) = x.Cons(char.ToCharArray())

        member x.ConsTag() =
            match x.Reader.ReadChar() with
            | TextParser.Whitespace _ -> ()
            | a -> (x.CurrentTag.Value).Cons(Char.ToLowerInvariant a)

        member x.ClearContent() = (x.Content.Value).Clear()

    // Tokenises a stream into a sequence of HTML tokens.
    let tokenise reader =
        let state = HtmlState.Create reader

        let rec data (state: HtmlState) =
            match state.Peek() with
            | '<' ->
                if state.ContentLength > 0 then
                    state.Emit()
                else
                    state.Pop()
                    tagOpen state
            | TextParser.EndOfFile _ -> state.Tokens.Value <- EOF :: state.Tokens.Value
            | '&' ->
                if state.ContentLength > 0 then
                    state.Emit()
                else
                    state.InsertionMode.Value <- CharRefMode
                    charRef state
            | _ ->
                match state.InsertionMode.Value with
                | DefaultMode ->
                    state.Cons()
                    data state
                | ScriptMode -> script state
                | FormattedMode ->
                    state.Cons()
                    data state
                | CharRefMode -> charRef state
                | DocTypeMode -> docType state
                | CommentMode -> comment state
                | CDATAMode -> data state

        and script state =
            match state.Peek() with
            | TextParser.EndOfFile _ -> data state
            | ''' ->
                state.Cons()
                scriptSingleQuoteString state
            | '"' ->
                state.Cons()
                scriptDoubleQuoteString state
            | '/' ->
                state.Cons()
                scriptSlash state
            | '<' ->
                state.Pop()
                scriptLessThanSign state
            | _ ->
                state.Cons()
                script state

        and scriptSingleQuoteString state =
            match state.Peek() with
            | TextParser.EndOfFile _ -> data state
            | ''' ->
                state.Cons()
                script state
            | '\\' ->
                state.Cons()
                scriptSingleQuoteStringBackslash state
            | _ ->
                state.Cons()
                scriptSingleQuoteString state

        and scriptDoubleQuoteString state =
            match state.Peek() with
            | TextParser.EndOfFile _ -> data state
            | '"' ->
                state.Cons()
                script state
            | '\\' ->
                state.Cons()
                scriptDoubleQuoteStringBackslash state
            | _ ->
                state.Cons()
                scriptDoubleQuoteString state

        and scriptSingleQuoteStringBackslash state =
            match state.Peek() with
            | _ ->
                state.Cons()
                scriptSingleQuoteString state

        and scriptDoubleQuoteStringBackslash state =
            match state.Peek() with
            | _ ->
                state.Cons()
                scriptDoubleQuoteString state

        and scriptSlash state =
            match state.Peek() with
            | '/' ->
                state.Cons()
                scriptSingleLineComment state
            | '*' ->
                state.Cons()
                scriptMultiLineComment state
            | _ -> script state

        and scriptMultiLineComment state =
            match state.Peek() with
            | TextParser.EndOfFile _ -> data state
            | '*' ->
                state.Cons()
                scriptMultiLineCommentStar state
            | _ ->
                state.Cons()
                scriptMultiLineComment state

        and scriptMultiLineCommentStar state =
            match state.Peek() with
            | TextParser.EndOfFile _ -> data state
            | '/' ->
                state.Cons()
                script state
            | _ -> scriptMultiLineComment state

        and scriptSingleLineComment state =
            match state.Peek() with
            | TextParser.EndOfFile _ -> data state
            | '\n' ->
                state.Cons()
                script state
            | _ ->
                state.Cons()
                scriptSingleLineComment state

        and scriptLessThanSign state =
            match state.Peek() with
            | '/' ->
                state.Pop()
                scriptEndTagOpen state
            | '!' ->
                state.Cons('<')
                state.Cons()
                scriptDataEscapeStart state
            | _ ->
                state.Cons('<')
                state.Cons()
                script state

        and scriptDataEscapeStart state =
            match state.Peek() with
            | '-' ->
                state.Cons()
                scriptDataEscapeStartDash state
            | _ -> script state

        and scriptDataEscapeStartDash state =
            match state.Peek() with
            | '-' ->
                state.Cons()
                scriptDataEscapedDashDash state
            | _ -> script state

        and scriptDataEscapedDashDash state =
            match state.Peek() with
            | TextParser.EndOfFile _ -> data state
            | '-' ->
                state.Cons()
                scriptDataEscapedDashDash state
            | '<' ->
                state.Pop()
                scriptDataEscapedLessThanSign state
            | '>' ->
                state.Cons()
                script state
            | _ ->
                state.Cons()
                scriptDataEscaped state

        and scriptDataEscapedLessThanSign state =
            match state.Peek() with
            | '/' ->
                state.Pop()
                scriptDataEscapedEndTagOpen state
            | TextParser.Letter _ ->
                state.Cons('<')
                state.Cons()
                scriptDataDoubleEscapeStart state
            | _ ->
                state.Cons('<')
                state.Cons()
                scriptDataEscaped state

        and scriptDataDoubleEscapeStart state =
            match state.Peek() with
            | TextParser.Whitespace _
            | '/'
            | '>' when state.IsScriptTag ->
                state.Cons()
                scriptDataDoubleEscaped state
            | TextParser.Letter _ ->
                state.Cons()
                scriptDataDoubleEscapeStart state
            | _ ->
                state.Cons()
                scriptDataEscaped state

        and scriptDataDoubleEscaped state =
            match state.Peek() with
            | TextParser.EndOfFile _ -> data state
            | '-' ->
                state.Cons()
                scriptDataDoubleEscapedDash state
            | '<' ->
                state.Cons()
                scriptDataDoubleEscapedLessThanSign state
            | _ ->
                state.Cons()
                scriptDataDoubleEscaped state

        and scriptDataDoubleEscapedDash state =
            match state.Peek() with
            | TextParser.EndOfFile _ -> data state
            | '-' ->
                state.Cons()
                scriptDataDoubleEscapedDashDash state
            | '<' ->
                state.Cons()
                scriptDataDoubleEscapedLessThanSign state
            | _ ->
                state.Cons()
                scriptDataDoubleEscaped state

        and scriptDataDoubleEscapedLessThanSign state =
            match state.Peek() with
            | '/' ->
                state.Cons()
                scriptDataDoubleEscapeEnd state
            | _ ->
                state.Cons()
                scriptDataDoubleEscaped state

        and scriptDataDoubleEscapeEnd state =
            match state.Peek() with
            | TextParser.Whitespace _
            | '/'
            | '>' when state.IsScriptTag ->
                state.Cons()
                scriptDataDoubleEscaped state
            | TextParser.Letter _ ->
                state.Cons()
                scriptDataDoubleEscapeEnd state
            | _ ->
                state.Cons()
                scriptDataDoubleEscaped state

        and scriptDataDoubleEscapedDashDash state =
            match state.Peek() with
            | TextParser.EndOfFile _ -> data state
            | '-' ->
                state.Cons()
                scriptDataDoubleEscapedDashDash state
            | '<' ->
                state.Cons()
                scriptDataDoubleEscapedLessThanSign state
            | '>' ->
                state.Cons()
                script state
            | _ ->
                state.Cons()
                scriptDataDoubleEscaped state

        and scriptDataEscapedEndTagOpen state =
            match state.Peek() with
            | TextParser.Letter _ -> scriptDataEscapedEndTagName state
            | _ ->
                state.Cons([| '<'; '/' |])
                state.Cons()
                scriptDataEscaped state

        and scriptDataEscapedEndTagName state =
            match state.Peek() with
            | TextParser.Whitespace _ when state.IsScriptTag ->
                state.Pop()
                beforeAttributeName state
            | '/' when state.IsScriptTag ->
                state.Pop()
                selfClosingStartTag state
            | '>' when state.IsScriptTag ->
                state.Pop()
                state.EmitTag(true)
            | '>' ->
                state.Cons([| '<'; '/' |])
                state.Cons(state.CurrentTagName())
                state.CurrentTag.Value.Clear()
                script state
            | TextParser.Letter _ ->
                state.ConsTag()
                scriptDataEscapedEndTagName state
            | _ ->
                state.Cons([| '<'; '/' |])
                state.Cons()
                scriptDataEscaped state

        and scriptDataEscaped state =
            match state.Peek() with
            | TextParser.EndOfFile _ -> data state
            | '-' ->
                state.Cons()
                scriptDataEscapedDash state
            | '<' -> scriptDataEscapedLessThanSign state
            | _ ->
                state.Cons()
                scriptDataEscaped state

        and scriptDataEscapedDash state =
            match state.Peek() with
            | TextParser.EndOfFile _ -> data state
            | '-' ->
                state.Cons()
                scriptDataEscapedDashDash state
            | '<' -> scriptDataEscapedLessThanSign state
            | _ ->
                state.Cons()
                scriptDataEscaped state

        and scriptEndTagOpen state =
            match state.Peek() with
            | TextParser.Letter _ -> scriptEndTagName state
            | _ ->
                state.Cons('<')
                state.Cons('/')
                script state

        and scriptEndTagName state =
            match state.Peek() with
            | TextParser.Whitespace _ ->
                state.Pop()
                beforeAttributeName state
            | '/' when state.IsScriptTag ->
                state.Pop()
                selfClosingStartTag state
            | '>' when state.IsScriptTag ->
                state.Pop()
                state.EmitTag(true)
            | TextParser.Letter _ ->
                state.ConsTag()
                scriptEndTagName state
            | _ ->
                state.Cons([| '<'; '/' |])
                state.Cons(state.CurrentTagName())
                state.CurrentTag.Value.Clear()
                script state

        and charRef state =
            match state.Peek() with
            | ';' ->
                state.Cons()
                state.Emit()
            | '<' -> state.Emit()
            | _ ->
                state.Cons()
                charRef state

        and tagOpen state =
            match state.Peek() with
            | '!' ->
                state.Pop()
                markupDeclaration state
            | '/' ->
                state.Pop()
                endTagOpen state
            | '?' ->
                state.Pop()
                bogusComment state
            | TextParser.Letter _ ->
                state.ConsTag()
                tagName false state
            | _ ->
                state.Cons('<')
                data state

        and bogusComment state =
            let rec bogusComment' (state: HtmlState) =
                let exitBogusComment state =
                    state.InsertionMode.Value <- CommentMode
                    state.Emit()

                match state.Peek() with
                | '>' ->
                    state.Cons()
                    exitBogusComment state
                | TextParser.EndOfFile _ -> exitBogusComment state
                | _ ->
                    state.Cons()
                    bogusComment' state

            bogusComment' state

        and markupDeclaration state =
            match state.Pop(2) with
            | [| '-'; '-' |] -> comment state
            | current ->
                match new String(Array.append current (state.Pop(5))) with
                | "DOCTYPE" -> docType state
                | "[CDATA[" ->
                    state.Cons("<![CDATA[".ToCharArray())
                    cData 0 state
                | _ -> bogusComment state

        and cData i (state: HtmlState) =
            match state.Peek() with
            | ']' when i = 0 || i = 1 ->
                state.Cons()
                cData (i + 1) state
            | '>' when i = 2 ->
                state.Cons()
                state.InsertionMode.Value <- CDATAMode
                state.Emit()
            | TextParser.EndOfFile _ ->
                state.InsertionMode.Value <- CDATAMode
                state.Emit()
            | _ ->
                state.Cons()
                cData 0 state

        and docType state =
            match state.Peek() with
            | '>' ->
                state.Pop()
                state.InsertionMode.Value <- DocTypeMode
                state.Emit()
            | _ ->
                state.Cons()
                docType state

        and comment state =
            match state.Peek() with
            | '-' ->
                state.Pop()
                commentEndDash state
            | TextParser.EndOfFile _ ->
                state.InsertionMode.Value <- CommentMode
                state.Emit()
            | _ ->
                state.Cons()
                comment state

        and commentEndDash state =
            match state.Peek() with
            | '-' ->
                state.Pop()
                commentEndState state
            | TextParser.EndOfFile _ ->
                state.InsertionMode.Value <- CommentMode
                state.Emit()
            | _ ->
                state.Cons()
                comment state

        and commentEndState state =
            match state.Peek() with
            | '>' ->
                state.Pop()
                state.InsertionMode.Value <- CommentMode
                state.Emit()
            | TextParser.EndOfFile _ ->
                state.InsertionMode.Value <- CommentMode
                state.Emit()
            | _ ->
                state.Cons()
                comment state

        and tagName isEndTag state =
            match state.Peek() with
            | TextParser.Whitespace _ ->
                state.Pop()
                beforeAttributeName state
            | '/' ->
                state.Pop()
                selfClosingStartTag state
            | '>' ->
                state.Pop()
                state.EmitTag(isEndTag)
            | _ ->
                state.ConsTag()
                tagName isEndTag state

        and selfClosingStartTag state =
            match state.Peek() with
            | '>' ->
                state.Pop()
                state.EmitSelfClosingTag()
            | TextParser.EndOfFile _ -> data state
            | _ -> beforeAttributeName state

        and endTagOpen state =
            match state.Peek() with
            | TextParser.EndOfFile _ -> data state
            | TextParser.Letter _ ->
                state.ConsTag()
                tagName true state
            | '>' ->
                state.Pop()
                data state
            | _ -> comment state

        and beforeAttributeName state =
            match state.Peek() with
            | TextParser.Whitespace _ ->
                state.Pop()
                beforeAttributeName state
            | '/' ->
                state.Pop()
                selfClosingStartTag state
            | '>' ->
                state.Pop()
                state.EmitTag(false)
            | _ -> attributeName state

        and attributeName state =
            match state.Peek() with
            | '=' ->
                state.Pop()
                beforeAttributeValue state
            | '/' ->
                state.Pop()
                selfClosingStartTag state
            | '>' ->
                state.Pop()
                state.EmitTag(false)
            | TextParser.LetterDigit _ ->
                state.ConsAttrName()
                attributeName state
            | TextParser.Whitespace _ -> afterAttributeName state
            | _ ->
                state.ConsAttrName()
                attributeName state

        and afterAttributeName state =
            match state.Peek() with
            | TextParser.Whitespace _ ->
                state.Pop()
                afterAttributeName state
            | '/' ->
                state.Pop()
                selfClosingStartTag state
            | '>' ->
                state.Pop()
                state.EmitTag(false)
            | '=' ->
                state.Pop()
                beforeAttributeValue state
            | _ ->
                state.NewAttribute()
                attributeName state

        and beforeAttributeValue state =
            match state.Peek() with
            | TextParser.Whitespace _ ->
                state.Pop()
                beforeAttributeValue state
            | '/' ->
                state.Pop()
                selfClosingStartTag state
            | '>' ->
                state.Pop()
                state.EmitTag(false)
            | '"' ->
                state.Pop()
                attributeValueQuoted '"' state
            | '\'' ->
                state.Pop()
                attributeValueQuoted '\'' state
            | _ -> attributeValueUnquoted state

        and attributeValueUnquoted state =
            match state.Peek() with
            | TextParser.Whitespace _ ->
                state.Pop()
                state.NewAttribute()
                beforeAttributeName state
            | '/' ->
                state.Pop()
                attributeValueUnquotedSlash state
            | '>' ->
                state.Pop()
                state.EmitTag(false)
            | '&' ->
                assert (state.ContentLength = 0)
                state.InsertionMode.Value <- InsertionMode.CharRefMode
                attributeValueUnquotedCharRef [ '/'; '>' ] state
            | _ ->
                state.ConsAttrValue()
                attributeValueUnquoted state

        and attributeValueUnquotedSlash state =
            match state.Peek() with
            | '>' -> selfClosingStartTag state
            | _ ->
                state.ConsAttrValue('/')
                state.ConsAttrValue()
                attributeValueUnquoted state

        and attributeValueQuoted quote state =
            match state.Peek() with
            | TextParser.EndOfFile _ -> data state
            | c when c = quote ->
                state.Pop()
                afterAttributeValueQuoted state
            | '&' ->
                assert (state.ContentLength = 0)
                state.InsertionMode.Value <- InsertionMode.CharRefMode
                attributeValueQuotedCharRef quote state
            | _ ->
                state.ConsAttrValue()
                attributeValueQuoted quote state

        and attributeValueQuotedCharRef quote state =
            match state.Peek() with
            | ';' ->
                state.Cons()
                state.EmitToAttributeValue()
                attributeValueQuoted quote state
            | TextParser.EndOfFile _ ->
                state.EmitToAttributeValue()
                attributeValueQuoted quote state
            | c when c = quote ->
                state.EmitToAttributeValue()
                attributeValueQuoted quote state
            | _ ->
                state.Cons()
                attributeValueQuotedCharRef quote state

        and attributeValueUnquotedCharRef stop state =
            match state.Peek() with
            | ';' ->
                state.Cons()
                state.EmitToAttributeValue()
                attributeValueUnquoted state
            | TextParser.EndOfFile _ ->
                state.EmitToAttributeValue()
                attributeValueUnquoted state
            | c when List.exists ((=) c) stop ->
                state.EmitToAttributeValue()
                attributeValueUnquoted state
            | _ ->
                state.Cons()
                attributeValueUnquotedCharRef stop state

        and afterAttributeValueQuoted state =
            match state.Peek() with
            | TextParser.Whitespace _ ->
                state.Pop()
                state.NewAttribute()
                afterAttributeValueQuoted state
            | '/' ->
                state.Pop()
                selfClosingStartTag state
            | '>' ->
                state.Pop()
                state.EmitTag(false)
            | _ ->
                state.NewAttribute()
                attributeName state

        let isEos = ref (state.Reader.IsEndOfString)

        while not isEos.Value do
            data state
            isEos.Value <- state.Reader.IsEndOfString

        state.Tokens.Value |> List.rev

    let rec parse
        (reader: StringReader)
        (callstack: Fable.Collections.Stack<string * HtmlNode list * string * string * string * HtmlAttribute list>)
        (docType: string)
        (elements: HtmlNode list)
        (expectedTagEnd: string)
        (parentTagName: string)
        (internalTokens: HtmlToken list)
        : string * list<HtmlToken> * list<HtmlNode> =

        let canNotHaveChildren (name: string) =
            match name with
            | "area"
            | "base"
            | "br"
            | "col"
            | "embed"
            | "hr"
            | "img"
            | "input"
            | "keygen"
            | "link"
            | "menuitem"
            | "meta"
            | "param"
            | "source"
            | "track"
            | "wbr" -> true
            | _ -> false

        let isImplicitlyClosedByStartTag expectedTagEnd startTag =
            match expectedTagEnd, startTag with
            | ("td"
              | "th"),
              ("tr"
              | "td"
              | "th") -> true
            | "tr", "tr" -> true
            | "li", "li" -> true
            | _ -> false

        let implicitlyCloseByStartTag expectedTagEnd startTag tokens =
            match expectedTagEnd, startTag with
            | ("td"
              | "th"),
              "tr" ->
                // the new tr is closing the cell and previous row
                TagEnd expectedTagEnd :: TagEnd "tr" :: tokens
            | ("td"
              | "th"),
              ("td"
              | "th")
            | "tr", "tr"
            | "li", "li" ->
                // tags are on same level, just close
                TagEnd expectedTagEnd :: tokens
            | _ -> tokens

        let isImplicitlyClosedByEndTag expectedTagEnd startTag =
            match expectedTagEnd, startTag with
            | ("td"
              | "th"
              | "tr"),
              ("thead"
              | "tbody"
              | "tfoot"
              | "table") -> true
            | "li", "ul" -> true
            | _ -> false

        let implicitlyCloseByEndTag expectedTagEnd tokens =
            match expectedTagEnd with
            | "td"
            | "th" ->
                // the end tag closes the cell and the row
                TagEnd expectedTagEnd :: TagEnd "tr" :: tokens
            | "tr"
            | "li" ->
                // Only on level need to be closed
                TagEnd expectedTagEnd :: tokens
            | _ -> tokens


        // let rec parse'
        //     (reader: StringReader)
        //     (callstack: Fable.Collections.Stack<string * HtmlNode list * string * string * string * HtmlAttribute list>)
        //     (docType: string)
        //     (elements: HtmlNode list)
        //     (expectedTagEnd: string)
        //     (parentTagName: string)
        //     (internalTokens: HtmlToken list)
        //     : string * list<HtmlToken> * list<HtmlNode> =

        // let parse' = parse' callstack

        let recursiveReturn (dt, tokens, content) =
            if callstack.Count = 0 then
                (dt, tokens, content)
            else

                let _, elements, expectedTagEnd, parentTagName, name, attributes = callstack.Pop()
                let e = HtmlElement(name, attributes, content)
                parse reader callstack dt (e :: elements) expectedTagEnd parentTagName tokens

        // let ret =
        match internalTokens with
        | DocType dt :: rest -> parse reader callstack (dt.Trim()) elements expectedTagEnd parentTagName rest
        | Tag (_, "br", []) :: rest ->
            let t = HtmlText Environment.NewLine
            parse reader callstack docType (t :: elements) expectedTagEnd parentTagName rest
        | Tag (true, name, attributes) :: rest ->
            let e = HtmlElement(name, attributes, [])
            parse reader callstack docType (e :: elements) expectedTagEnd parentTagName rest
        | Tag (false, name, attributes) :: rest when canNotHaveChildren name ->
            let e = HtmlElement(name, attributes, [])
            parse reader callstack docType (e :: elements) expectedTagEnd parentTagName rest
        | Tag (_, name, _) :: _ when isImplicitlyClosedByStartTag expectedTagEnd name ->
            // insert missing </tr> </td> or </th> when starting new row/cell/header
            parse
                reader
                callstack
                docType
                elements
                expectedTagEnd
                parentTagName
                (implicitlyCloseByStartTag expectedTagEnd name internalTokens)
        | TagEnd (name) :: _ when isImplicitlyClosedByEndTag expectedTagEnd name ->
            // insert missing </tr> </td> or </th> when starting new row/cell/header
            parse
                reader
                callstack
                docType
                elements
                expectedTagEnd
                parentTagName
                (implicitlyCloseByEndTag expectedTagEnd internalTokens)

        | Tag (_, name, attributes) :: rest ->
            (docType, elements, expectedTagEnd, parentTagName, name, attributes)
            |> callstack.Push

            parse reader callstack docType [] name expectedTagEnd rest
        | TagEnd name :: _ when name <> expectedTagEnd && name = parentTagName ->
            // insert missing closing tag
            parse
                reader
                callstack
                docType
                elements
                expectedTagEnd
                parentTagName
                (TagEnd expectedTagEnd :: internalTokens)
        | TagEnd name :: rest when
            name <> expectedTagEnd
            && (name
                <> (new String(expectedTagEnd.ToCharArray() |> Array.rev)))
            ->
            // ignore this token if not the expected end tag (or it's reverse, eg: <li></il>)
            parse reader callstack docType elements expectedTagEnd parentTagName rest
        | TagEnd _ :: rest -> recursiveReturn (docType, rest, List.rev elements)
        | Text cont :: rest ->
            if cont = "" then
                // ignore this token
                parse reader callstack docType elements expectedTagEnd parentTagName rest
            else
                let t = HtmlText cont
                parse reader callstack docType (t :: elements) expectedTagEnd parentTagName rest
        | Comment cont :: rest ->
            let c = HtmlComment cont
            parse reader callstack docType (c :: elements) expectedTagEnd parentTagName rest
        | CData cont :: rest ->
            let c = HtmlCData cont
            parse reader callstack docType (c :: elements) expectedTagEnd parentTagName rest
        | EOF :: _ -> recursiveReturn (docType, [], List.rev elements)
        | [] -> recursiveReturn (docType, [], List.rev elements)

    // let tokens = tokenise reader

    // let docType, _, elements = ret
    // tokens
    // |> parse reader callstack (new Fable.Collections.Stack<_>()) "" [] "" ""

    // if List.isEmpty elements then
    //     failwith "Invalid HTML"

    // ret


    let parseDocument reader = () // HtmlDocument(parse reader)

    /// All attribute names and tag names will be normalized to lowercase
    /// All html entities will be replaced by the corresponding characters
    /// All the consecutive whitespace (except for `&nbsp;`) will be collapsed to a single space
    /// All br tags will be replaced by newlines
    let parseFragment reader tokens =
        let a, b, c = parse reader (new Fable.Collections.Stack<_>()) "" [] "" "" tokens
        c

// --------------------------------------------------------------------------------------

// type HtmlDocument with

//     /// Parses the specified HTML string
//     static member Parse(text) =
//         let reader = StringReader(text)
//         HtmlParser.parseDocument reader

type HtmlNode with

    /// Parses the specified HTML string to a list of HTML nodes
    static member Parse(text) =
        let reader = StringReader(text)
        let tokens = HtmlParser.tokenise reader
        HtmlParser.parseFragment reader tokens

// static member ParseRooted(rootName, text) =
//     let reader = StringReader(text)
//     HtmlElement(rootName, [], HtmlParser.parseFragment reader)
