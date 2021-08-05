# App

## Create Project
```bash
$ dotnet new console -lang "F#" -o App
$ dotnet sln add App/App.fsproj
```

## Add Dependencies
```bash
$ touch App/paket.references
$ dotnet paket add FSharp.Control.Reactive --version 5.0.2 --project App
$ dotnet add App/App.fsproj reference LibOne/LibOne.fsproj
```

## Install Dependencies
```bash
$ dotnet paket install
```

## Build
```bash
$ dotnet build
```

## Run
```bash
$ dotnet run --project App
```
