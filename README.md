# MaterialDesignMessageBox

A simple material design themed message box for use with WPF applications

[![NuGet Status](https://img.shields.io/nuget/v/MaterialDesignMessageBox.svg?style=flat&label=MaterialDesignMessageBox)](https://www.nuget.org/packages/MaterialDesignMessageBox/)

![GitHub](https://img.shields.io/github/license/kylelaverty/MaterialDesignMessageBox)

## Installation Guide

Use the following command to install:

```powershell
Install-Package MaterialDesignMessageBox
```

## Usage Guide

### Example

```C#
MaterialMessageBox.ShowDialog("Your Message ... ");
```

### Full Signature

```C#
MaterialMessageBox.ShowDialog(
    Window owner,
    string messageBoxText,
    string caption,
    MessageBoxButton button,
    PackIconKind icon,
    PrimaryColor stylePrimaryColor);
```

## Method Parameters

| Property          | Type             | Required | Description                                                         |
| ----------------- | ---------------- | -------- | ------------------------------------------------------------------- |
| owner             | Window           | N        | WPF Window that owns this message box                               |
| messageBoxText    | string           | Y        | Message to display in the message box                               |
| caption           | string           | N        | Text to display in the title of the message box                     |
| button            | MessageBoxButton | N        | Enum of which buttons to display (OK, OKCancel, YesNo, YesNoCancel) |
| icon              | PackIconKind     | N        | Icon to use in the message box                                      |
| stylePrimaryColor | PrimaryColor     | N        | Set the button colors based on the PrimaryColor enum                |

### Enum Values

#### MessageBoxButton

- OK
- OKCancel
- YesNo
- YesNoCancel

#### PackIconKind

This is from the [MaterialDesignInXamlToolkit](https://github.com/MaterialDesignInXAML/MaterialDesignInXamlToolkit) repo and is a reference to the names of the icons from the [Material Design Icons](https://materialdesignicons.com/) site.

#### PrimaryColor

This is from the [MaterialDesignInXamlToolkit](https://github.com/MaterialDesignInXAML/MaterialDesignInXamlToolkit) repo's PrimaryColor enum.
