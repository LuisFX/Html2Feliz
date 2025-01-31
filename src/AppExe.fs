module AppExe

open System
// open Elmish
// open Elmish.React
// open Feliz
// open Feliz.Bulma
// open FSharp.Data.LiteralProviders
// open Fable.Core.JsInterop
// open Zanaptak.TypedCssClasses
// open Fable.SimpleHttp
open FSharp.Data
open System.IO
open Feliz
open Fable.SimpleHttp

let printUsage () =
    printfn "Usage:"
    printfn "--help: Print usage"
    printfn "--url <url>: The URL to be scraped and parsed"
    printfn "--html <html>: HTML string to be parsed"
    printfn "--output <filename>: The filename to write to (default: output.fs)"

[<EntryPoint>]
let main argv =
    let parse htmlStr =
        try
            HtmlNode.Parse htmlStr |> Ok
        with
        | err -> Error $"{err}"

    let scrapeWebPage (url: string) =
        let output = Http.get(url) |> Async.RunSynchronously
        match output with
        | 200, html -> html
        | _ -> failwith "Failed to scrape the web page"

    let mutable url = ""
    let mutable html = ""
    let mutable output = "output.fs"

    let rec parseArgs args =
        match args with
        | [] -> ()
        | "--help" :: _ ->
            printUsage()
            Environment.Exit(0)
        | "--url" :: value :: tail ->
            url <- value
            parseArgs tail
        | "--html" :: value :: tail ->
            html <- value
            parseArgs tail
        | "--output" :: value :: tail ->
            output <- value
            parseArgs tail
        | _ -> 
            printUsage()
            Environment.Exit(1)

    parseArgs (List.ofArray argv)

    if url <> "" && html <> "" then
        printfn "Cannot provide both --url and --html. Please provide only one."

    let felizOutput =
        if url <> "" then
            let htmlScrape = scrapeWebPage url
            parse htmlScrape
        elif html <> "" then
            parse html
        else
            printfn "Either --url or --html must be provided"
            Environment.Exit(1)
            failwith ""
            

    match felizOutput with
    | Ok htmlNodes ->
        let nodes = Html2Feliz.format htmlNodes true
        File.WriteAllText(output, nodes)
    | Error err -> failwithf "Error: %s" err

    0 // return an integer exit code
