namespace CS10;

using System.Text.Json.Serialization;

public record Person(string FirstName, string LastName);

public record Person2([property: JsonPropertyName("firstName")]string FirstName, 
    [property: JsonPropertyName("lastName")]string LastName);
