
using DuckTesting;

namespace DuckTesting.Tests;

public class DuckTests
{
    [Theory]
    [InlineData("Kalle", "Kalle quacks!")]
    [InlineData("Kajsa", "Kajsa quacks!")]
    [InlineData("Donald", "Donald quacks!")]
    public void Quack_ReturnsCorrectText(string name, string expected)
    {
        // Arrange
        Duck duck = new() { Name = name };

        // Act
        string result = duck.Quack();

        // Assert
        Assert.Equal(expected, result);
    }
}
