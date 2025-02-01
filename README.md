# HTML2Feliz

A small tool to generate [Feliz](https://zaid-ajaj.github.io/Feliz/) code from given HTML input.

Here is a [Demo](https://thisfunctionaltom.github.io/Html2Feliz/)

## Building & Testing

Before you can do anything you have to restore dotnet tools with `dotnet tool restore` and npm packages with `npm install`.

To run it locally in your browser type `npm start` and then open [localhost](http://localhost:3000)
To build the App use `npm build`.

To deploy to github pages use `npm deploy`.


## Building and Publishing the cli executable

macos
```sh
dotnet publish --runtime osx.11.0-arm64 -p:PublishSingleFile=true -p:IncludeNativeLibrariesForSelfExtract=true  --self-contained true -c release
```

## CLI usage

```sh
./Html2Feliz --url https://huro.cssninja.io/webapp-action-page-1.html --output ActionPage1.fs
```