using FluentAssertions;

namespace FactorialTdd.Tests;

public class FactorialCalculatorTests
{
    private readonly FactorialCalculator _calculator;

    public FactorialCalculatorTests()
    {
        _calculator = new FactorialCalculator();
    }

    [Fact]
    public void Calculate_GivenZero_ShouldReturnOne()
    {
        // Arrange
        const int number = 0;

        // Act
        long result = _calculator.Calculate(number);

        // Assert
        result.Should().Be(1);
    }

    [Theory]
    [InlineData(1, 1)]
    [InlineData(2, 2)]
    [InlineData(3, 6)]
    [InlineData(4, 24)]
    [InlineData(5, 120)]
    [InlineData(10, 3628800)]
    public void Calculate_GivenPositiveNumber_ShouldReturnFactorial(int number, long expected)
    {
        // Act
        long result = _calculator.Calculate(number);

        // Assert
        result.Should().Be(expected);
    }

    [Fact]
    public void Calculate_GivenNegativeNumber_ShouldThrowArgumentException()
    {
        // Arrange
        int number = -1;

        // Act
        Action act = () => _calculator.Calculate(number);

        // Assert
        act.Should().Throw<ArgumentException>()
            .WithMessage("Factorial is not defined for negative numbers.");
    }
}
