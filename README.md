[![NuGet](https://img.shields.io/nuget/v/tools2807-lib.svg?label=NuGet)](https://nuget.org/packages/tools2807-lib)
# tools2807-lib
tools2807-lib implements [tools.2807.eu](https://tools.2807.eu/) API into easy to use C# library.

# Example usage
```csharp
var tools = new tools2807.tools2807();

tools2807.Types.User[] vips = await tools.GetVips("xslash58");
Console.WriteLine(vips[0].login);
```
More on [wiki](https://github.com/Xslash58/tools2807-lib/wiki)<br>

# Dependencies
tools2807-lib is using [Newtonsoft.JSON](https://www.newtonsoft.com/json) to deserialize data from the API.

# I want to use it in Unity!
As tools2807-lib is written in .NET Standard 2.1 you have to change 'Api Compatibility Level' to .NET 4.x.
[How to do it](https://learn.microsoft.com/en-us/visualstudio/gamedev/unity/unity-scripting-upgrade)
