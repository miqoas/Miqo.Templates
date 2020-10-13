# Miqo.Templates for dotnet

An easy to use dotnet template to quickly create a .NET 5 Blazor Component with a code-behind and CSS isolated file.

## Getting started

### Installation

You can install the templates by running the following command:

```bash
dotnet new -i Miqo.Templates
```

## Usage

To create a new Blazor Component, you can run the following command:

```bash
dotnet new miqo-blazorcss [options]
```

This will create a new Blazor component with a code-behind and CSS file in the current folder. You can set the name of the new component with the `-n` option like this:

```bash
dotnet new miqo-blazorcss -n Alerts
```

## Notes

You currently have to set the component's .cs file namespace manually.
