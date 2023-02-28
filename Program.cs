global using static System.Math; // Math will be imported in all classes of the CS10 namespace.
using CS10;

Console.WriteLine("Hello, World!");

var dm = new DataMeasurment();

Point p1 = new() { X = 1, Y = 2, Z = 3, };
Point p2 = new() { X = 2, Y = 2, Z = 2, };

Person person = new("a", "b");
var (FirstName, LastName) = person;
Console.WriteLine($"{FirstName} {LastName}");

Person2 person2 = new("a", "b");
Console.WriteLine($"{person2.FirstName} {person2.LastName}");

GlobalUsing globalUsing = new();
globalUsing.GetSquareRoot();
