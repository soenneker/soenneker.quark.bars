[![](https://img.shields.io/nuget/v/soenneker.quark.bars.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.quark.bars/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.quark.bars/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.quark.bars/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.quark.bars.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.quark.bars/)
[![](https://img.shields.io/badge/Demo-Live-blueviolet?style=for-the-badge&logo=github)](https://soenneker.github.io/soenneker.quark.bars/)

# Soenneker.Quark.Bars

A Blazor UI wrapper for navigation bars.

## Features

- Navigation bar components
- Support for different bar types (navbar, header, footer, toolbar)
- Placement options (top, bottom, fixed, sticky)
- Color theming support
- Responsive design with Bootstrap classes
- Dark mode support
- Transparent backgrounds

## Components

- `Bar` - Main navigation bar component
- `BarBrand` - Brand/logo area
- `BarToggler` - Mobile menu toggle button
- `BarCollapse` - Collapsible content area
- `BarNav` - Navigation container
- `BarItem` - Individual navigation item
- `BarLink` - Navigation link

## Usage

```razor
<Bar Color="@Color.Light">
    <BarBrand Href="#">My App</BarBrand>
    <BarToggler Target="#navbarNav" />
    <BarCollapse Id="navbarNav">
        <BarNav>
            <BarItem>
                <BarLink Href="#" Active="true">Home</BarLink>
            </BarItem>
            <BarItem>
                <BarLink Href="#">About</BarLink>
            </BarItem>
        </BarNav>
    </BarCollapse>
</Bar>
```

## Installation

```bash
dotnet add package Soenneker.Quark.Bars
```

## Dependencies

- Soenneker.Quark.Components
- Soenneker.Quark.Enums.Colors
- Soenneker.Quark.Divs