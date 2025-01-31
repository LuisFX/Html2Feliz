module Html2Feliz

open System
open FSharp.Data

let capitalize (s: string) =
    s.[0].ToString().ToUpperInvariant()
    + s.[1..].ToLowerInvariant()

let toCamelCase (words: string []) =
    let convertWord i word =
        if i > 0 then
            capitalize word
        else
            word.ToLowerInvariant()

    words |> Array.mapi convertWord

let formatAttributeName (attr: string) =
    let name =
        attr.Split('-') |> toCamelCase |> String.concat ""

    Mappings.propNames
    |> Map.tryFind name
    |> Option.defaultValue name
    |> function
        // | "onclick" -> "onClick"
        | other -> other

let rec compressSpaces (text: string) =
    let compressed = text.Replace("  ", " ")

    if compressed <> text then
        compressSpaces compressed
    else
        compressed

type ChildPosition =
    | FirstChild
    | MiddleChild
    | LastChild
    | SingleChild

let toPositionedChildren (children: HtmlNode list) =
    match children with
    | [] -> []
    | [ child ] -> [ SingleChild, child ]
    | _ ->
        let lastIdx = children.Length - 1

        children
        |> List.mapi
            (fun idx child ->
                if idx = 0 then FirstChild, child
                elif idx = lastIdx then LastChild, child
                else MiddleChild, child)

let rec formatTextProp (pos: ChildPosition) (text: string) =
    let formatted =
        text.Replace("\n", " ").Replace("\r", " ")
        |> compressSpaces

    match pos with
    | FirstChild -> formatted.TrimStart()
    | LastChild -> formatted.TrimEnd()
    | SingleChild -> formatted.Trim()
    | MiddleChild -> formatted

let inline tryParse<'a> (f: string -> (bool * 'a)) value : option<string> =
    match f value with
    | true, x -> Some(string x)
    | _ -> None

let formatAttributeValue name value =
    Mappings.propertyTypes
    |> Map.tryFind name
    |> Option.defaultValue List.empty
    |> List.sortBy
        (fun propType ->
            [ "bool"; "int"; "float" ]
            |> List.findIndex ((=) propType))
    |> List.map
        (fun types ->
            // printfn $"{name}: {types}"
            types)
    |> List.tryPick
        (fun propType ->
            match propType with
            | "bool" -> Some "true"
            | "int" -> tryParse Int32.TryParse value
            | "float" -> tryParse Double.TryParse value
            | _ -> None)
    |> Option.defaultValue $"\"{value}\""

let unsupportedAttributes =
    [
        "http-equiv"
        "onclick"
        "aria-current"
        "aria-haspopup"
        // "data-feather"
        // "data-target"
        // "data-style"
        // "data-user-popover"
        // "data-demo-src"
    ]

let formatAttribute indent level (HtmlAttribute (attrName, attrValue)) =
    let indentStr = String(' ', indent * level)

    match attrName with
    | "class" ->
        let classes = attrValue.Split(' ')

        match classes with
        | [| single |] -> $"{indentStr}prop.className \"{single}\""
        | multi ->
            let classes =
                multi
                |> Array.map (sprintf "\"%s\"")
                |> String.concat "; "

            $"{indentStr}prop.classes [ {classes} ]"

    | attr when attr.Contains("data-") ->
        let propName = formatAttributeName attrName
        let propValue = formatAttributeValue attrName attrValue

        sprintf $@"{indentStr}//prop.{propName} {propValue}"

    | attr when List.contains attr unsupportedAttributes ->
        // Add a comment for unsupported attributes
        $"{indentStr}//prop.{attrName} \"{attrValue}\""
    
    | "aria-hidden" ->
        // Fix for aria-hidden attribute
        $"{indentStr}prop.ariaHidden true"
    // | "visibility"
    // | "display" ->
    //     // Fix for display attribute
    //     $"//{indentStr}prop.style [ style.display\"{attrValue}\" ]"
    | "style" ->
        let styles = attrValue.Split(';')
        let formattedStyles =
            styles
            |> Array.map (fun s -> 
                let parts = s.Split(':')
                if parts.Length = 2 then
                    let name = parts.[0].Trim()
                    let value = parts.[1].Trim()
                    match name with
                    | "height" | "width" | "font-size" | "font-weight" ->
                        //  (length.px 30)"
                        $"""style.{name} (length.px {int (value.Replace("px", ""))})"""
                    | "display" | "visibility" ->
                        $"style.{name}.{value}"

                    | "color" | "background-color" ->
                        $"style.{name} \"{value}\""
                    | _ ->
                        $"style.{name} {value}"
                else
                    "")
            |> Array.filter (fun s -> s <> "")
            |> String.concat "; "

        $"{indentStr}prop.style [ {formattedStyles} ]"
    | _ ->
        let propName = formatAttributeName attrName
        let propValue = formatAttributeValue attrName attrValue

        sprintf $@"{indentStr}prop.{propName} {propValue}"

let containsOnlyCommentsOrEmptyText (elements: HtmlNode list) =
    elements
    |> List.forall
        (function
        | HtmlComment _
        | HtmlText "" -> true
        | _ -> false)

let emptyChildren (elements: HtmlNode list) =
    elements.IsEmpty
    || containsOnlyCommentsOrEmptyText elements

let (|EmptyChildren|SingleTextNode|Children|) (elements: HtmlNode list) =
    match elements with
    | children when emptyChildren children -> EmptyChildren
    | [ HtmlText text ] -> SingleTextNode text
    | _ -> Children elements

let formatNodeName (name: string) =
    Mappings.htmlNames
    |> Map.tryFind name
    |> Option.defaultValue name

let rec formatNode indent level (pos: ChildPosition, node: HtmlNode) =
    let line level text =
        let indentStr = String(' ', indent * level)
        sprintf "%s%s" indentStr text

    seq {
        match node with
        | HtmlText "" -> ()
        | HtmlComment _comment -> ()
        | HtmlText text -> line level $"Html.text \"{formatTextProp pos text}\""
        | HtmlElement (name, [], children) when emptyChildren children -> line level ($"Html.{formatNodeName name} []")
        | HtmlElement (name, [], SingleTextNode text) when name <> "a" ->
            line level ($"Html.{formatNodeName name} \"{formatTextProp pos text}\"")        
        | HtmlElement ("a", [], SingleTextNode text) ->
            line level ($"Html.a [ prop.text \"{formatTextProp pos text}\" ]")
        | HtmlElement ("a", attrs, EmptyChildren) ->
            line level ($"Html.a [")

            for attr in attrs do
                formatAttribute indent (level + 1) attr

            line level "]"
        | HtmlElement (name, attrs, EmptyChildren) ->
            line level ($"Html.{formatNodeName name} [")

            for attr in attrs do
                formatAttribute indent (level + 1) attr

            line level "]"
        | HtmlElement (name, [], children) ->
            // when there are no attributes
            // no need for prop.children
            line level $"Html.{formatNodeName name} ["

            for child in toPositionedChildren children do
                yield! formatNode indent (level + 1) child

            line level "]"
        | HtmlElement ("a", attrs, children) ->
            line level $"Html.a ["

            for attr in attrs |> List.sort do
                formatAttribute indent (level + 1) attr

            match children with
            | EmptyChildren -> ()
            | SingleTextNode text -> line (level + 1) $"prop.text \"{formatTextProp pos text}\""
            | Children children ->
                line (level + 1) "prop.children ["

                for child in toPositionedChildren children do
                    yield! formatNode indent (level + 2) child

                line (level + 1) "]"

            line level "]"
        | HtmlElement (name, attrs, children) ->
            line level $"Html.{formatNodeName name} ["

            for attr in attrs |> List.sort do
                formatAttribute indent (level + 1) attr

            match children with
            | EmptyChildren -> ()
            | SingleTextNode text -> line (level + 1) $"prop.text \"{formatTextProp pos text}\""
            | Children children ->
                line (level + 1) "prop.children ["

                for child in toPositionedChildren children do
                    yield! formatNode indent (level + 2) child

                line (level + 1) "]"

            line level "]"
        | HtmlCData _content -> ()
    }

let format (nodes: HtmlNode list) (returnAsFelizPage: bool) =
    let formattedNodes =
        [ for node in toPositionedChildren nodes do
              yield! formatNode 4 0 node ]
        |> String.concat "\n"

    if returnAsFelizPage then
        let nodesWith3tabs =
            formattedNodes.Split('\n')
            |> Array.map (fun s -> "            " + s)
            |> String.concat "\n"
        
        let outputInTemplate = $"""
namespace FelizPage

open Feliz

module rec Page =

    [<ReactComponent>]
    let Page () =
        React.fragment [
{nodesWith3tabs}
        ]
        """
        outputInTemplate
    else
        formattedNodes
