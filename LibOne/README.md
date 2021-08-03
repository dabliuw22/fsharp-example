# LibOne

## Create Project
```bash
$ dotnet new classlib -lang "F#" -o LibOne
$ dotnet sln add LibOne/LibOne.fsproj
```

## Add Dependencies
```bash
$ touch LibOne/paket.references
$ dotnet paket add FSharp.Control.Reactive --version 5.0.2 --project LibOne
```
