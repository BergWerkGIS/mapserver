#r "..\..\..\build\mapscript\csharp\mapscript_csharp.dll"

using OSGeo.MapServer;

Console.WriteLine($"UMN version  : {mapscript.msGetVersionInt()}");
Console.WriteLine($"UMN version full : {mapscript.msGetVersion()}");
