
namespace DuckTesting;

public class Duck
{
    public required string Name { get; init; }

    public string Quack() => $"{Name} says hello!";
}
