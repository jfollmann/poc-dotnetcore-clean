# Dotnet Core Notes

## Create a solution
```bash
dotnet new sln --name "PocWise"
```

## List project type templates
```bash
dotnet new list | grep class
```

## Create a class library project
```bash
dotnet new classlib --framework net8.0 -n PocWise.Domain
```

## Create a console application project
```bash
dotnet new console --framework net8.0 --use-program-main -n PocWise.Main
```

## Create a test project
```bash
dotnet new xunit -o PocWise.Main
```

## Add project in solution
```bash
dotnet sln add ./PocWise.Main/PocWise.Main.csproj
```

## Add reference between two projects
```bash
dotnet add PocWise.Main/PocWise.Main.csproj reference PocWise.Domain/PocWise.Domain.csproj
```

## Build solution
```bash
dotnet build PocWise.sln
```

## Build only one project
```bash
dotnet build PocWise.Main/PocWise.Main.csproj
```

## Run project
```bash
dotnet run --project PocWise.Main
```

## Run only one tests
```bash
dotnet test tests/PocWise.Domain.Tests
```

## Run all tests
```bash
dotnet test PocWise.sln
```

## Run all tests with details
```bash
dotnet test PocWise.sln -l "console;verbosity=normal"
```

## Install package
```bash
dotnet add tests/PocWise.Domain.Tests/PocWise.Domain.Tests.csproj package Moq
```

## VsCode extensions
- https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csharp
- https://marketplace.visualstudio.com/items?itemName=kreativ-software.csharpextensions
- https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csdevkit