# fsharp-example

## Create Project
```bash
$ dotnet new sln -o fsharp-example
```

## Init Paket
```bash
$ cd fsharp-example
$ dotnet paket init
```

## Add Subprojects
```bash
$ cd fsharp-example
$ dotnet sln add LibOne/LibOne.fsproj
$ dotnet sln add App/App.fsproj
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