[![NuGet version (FluentAssertions.BUnit)](https://img.shields.io/nuget/v/FluentAssertions.BUnit.svg?style=flat-square)](https://www.nuget.org/packages/FluentAssertions.BUnit/)
[![Nuget](https://img.shields.io/nuget/dt/FluentAssertions.BUnit?logo=nuget&style=flat-square)](https://www.nuget.org/packages/FluentAssertions.BUnit/)
[![.NET](https://github.com/srpeirce/fluentassertions.bUnit/actions/workflows/dotnet.yml/badge.svg)](https://github.com/srpeirce/fluentassertions.bUnit/actions/workflows/dotnet.yml)
[![MIT License](https://img.shields.io/github/license/dotnet/aspnetcore?color=%230b0&style=flat-square)](https://github.com/srpeirce/fluentassertions.bUnit/blob/main/LICENSE)

# Fluentassertions.bUnit

FluentAssertions.bUnit is an assertions library that is used in conjunction with bUnit.

It offers fluent assertions syntax to rendered components.

## Why?

- Great for TDD
- Great for writing non-brittle tests


## Getting Started

Install Nuget Package into test project:
```
dotnet install FluentAssertions.BUnit
```

Use bUnit to render component.

Then write assertions...

```csharp
    [Fact]
    public void RenderWithChildContent()
    {
        var cut = Render(@<Button><h1>Test</h1></Button>);
        
        cut.AsElement()
            .ShouldHaveTag("button")
            .ShouldHaveChildMarkup(@<h1>Test</h1>);
    }

    [Fact]
    public void SetDefaultCssClasses()
    {
        var cut = Render(@<Button><h1>Test</h1></Button>);

        cut.AsElement()
            .ShouldHaveClass("btn")
            .ShouldHaveClass("btn-primary")
            .ShouldNotHaveClass("btn-outline-success");
    }
```

## Documentation

Use intellisense and look at the code for now :-)

### Find Element

[Find Element](https://github.com/srpeirce/fluentassertions.bUnit/blob/main/FluentAssertions.BUnit/BUnitExtensions.cs)

### Assertions

[Assertions](https://github.com/srpeirce/fluentassertions.bUnit/blob/main/FluentAssertions.BUnit/BUnitAssertions.cs)

## Contributions

Currently in a very early version/stage of this project.

Please raise issues and feel free to submit PRs (happy to discuss in an issue first to avoid wasted effort).


## Examples

Todo...