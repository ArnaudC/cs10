global using static System.Math; // Math will be imported in all classes of the CS10 namespace.
using System.Diagnostics.CodeAnalysis;
using CS10;

Console.WriteLine("Hello, World!");

var dm = new DataMeasurment() { Measurement = 20 };

Point p1 = new() { X = 1, Y = 2, Z = 3, };
Point p2 = new() { X = 2, Y = 2, Z = 2, };

Person person = new("a", "b");
var (FirstName, LastName) = person;
Console.WriteLine($"{FirstName} {LastName}");

Person2 person2 = new("a", "b");
Console.WriteLine($"{person2.FirstName} {person2.LastName}");

GlobalUsing globalUsing = new();
globalUsing.GetSquareRoot();

// Extended property patterns
ExtendedPropertyPatterns extendedPropertyPatterns = new ExtendedPropertyPatterns();
double res = extendedPropertyPatterns.SwitchOnExtendedPropertyPatterns(dm);
Console.WriteLine($"res={res}");

// Lambda expression improvements
var parsedInteger = (string s) => int.Parse(s); // Extended property patterns
var choose = object (bool b) => b ? 1 : "two"; // declare a return type when the compiler can't infer it
var concat = ([DisallowNull] string a, [DisallowNull] string b) => a + b; // Attributes can be applied to lambda expressions.

// Constant interpolated strings
const string myRootPath = "/src/to/my/root";
const string myWholeFilePath = $"{myRootPath}/README.md";
Console.WriteLine(myWholeFilePath);

// Record types can seal ToString
// public sealed record Person(string FirstName, string LastName);
// public record Me(string FirstName, string LastName) : Person(FirstName, LastName); // Error

// Assignment and declaration in same deconstruction
double x = 0;
(x, double y) = p1;

// Improved definite assignment
// string representation = "N/A";
// if ((c != null && c.GetDependentValue(out object obj)) == true)
// {
//    representation = obj.ToString(); // undesired error
// }

// Allow AsyncMethodBuilder attribute on methods
// var callerArgumentExpressionCustom = new CallerArgumentExpressionCustom();
// Action<string> greet = name =>
// {
//     string greeting = $"Hello {name}!";
//     Console.WriteLine(greeting);
// };
// callerArgumentExpressionCustom.Operation(greet);
