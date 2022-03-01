// See https://aka.ms/new-console-template for more information

using Microsoft.EntityFrameworkCore;
using SomeEFUsingClassLib;

var options = new DbContextOptions<SomeContext>();
var context = new SomeContext(options);
var array = context.Foo.ToArray();
Console.WriteLine($"Found {array.Length} rows");