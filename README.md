# Cake.MobileCenter

A Cake AddIn that extends Cake with [MobileCenter](https://docs.microsoft.com/en-us/mobile-center/) command tools.

IMPORTANT: Microsoft deprecated Mobile Center and moved it to [App Center](https://docs.microsoft.com/en-us/appcenter/cli/). This addin is in maintenance mode, further developement will be done on [Cake.AppCenter](https://github.com/cake-contrib/Cake.AppCenter).

[![cakebuild.net](https://img.shields.io/badge/WWW-cakebuild.net-blue.svg)](http://cakebuild.net/)
[![NuGet](https://img.shields.io/nuget/v/Cake.MobileCenter.svg)](https://www.nuget.org/packages/Cake.MobileCenter)

## Important

Since 1.1.0 it supports Cake 0.26 and .NET Standard 2.0 only.

## Including addin
Including addin in cake script is easy.
```
#addin "Cake.MobileCenter"
```
## Usage

To use the addin just add it to Cake call the aliases and configure any settings you want.

```csharp
#addin "Cake.MobileCenter"

...

// How to login using a token
Task("Login")
	.Does(() => {
		// or more containers at once
		MobileCenterLogin(new MobileCenterLoginSettings{ Token = "YOUR_TOKEN_HERE" });
	)};
```
Other commands follow same convention.

This version is built against MobileCenter CLI tools version 0.11.0.

## Credits

Brought to you by [Miha Markic](https://github.com/MihaMarkic) ([@MihaMarkic](https://twitter.com/MihaMarkic/)) and contributors.
