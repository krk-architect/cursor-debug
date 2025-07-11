using Lib1;

var str = "Hello, World!";

Console.WriteLine($"IsNullOrEmpty: {str.IsNullOrEmpty()}"); // breakpoint set on this line and debugger stops here

str = null;

Console.WriteLine($"IsNullOrEmpty: {str.IsNullOrEmpty()}");
