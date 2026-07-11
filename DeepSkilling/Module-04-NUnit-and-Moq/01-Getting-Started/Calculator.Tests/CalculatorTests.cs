using NUnit.Framework;
using Calculator;

namespace Calculator.Tests;

public class CalculatorTests
{
    private Calculator calculator = null!;

    [SetUp]
    public void Setup()
    {
        calculator = new Calculator();
    }

    [Test]
    public void Add_ReturnsCorrectResult()
    {
        Assert.That(calculator.Add(5, 3), Is.EqualTo(8));
    }

    [Test]
    public void Subtract_ReturnsCorrectResult()
    {
        Assert.That(calculator.Subtract(10, 4), Is.EqualTo(6));
    }

    [Test]
    public void Multiply_ReturnsCorrectResult()
    {
        Assert.That(calculator.Multiply(5, 4), Is.EqualTo(20));
    }

    [Test]
    public void Divide_ReturnsCorrectResult()
    {
        Assert.That(calculator.Divide(20, 5), Is.EqualTo(4));
    }

    [Test]
    public void Divide_ByZero_ThrowsException()
    {
        Assert.Throws<DivideByZeroException>(() => calculator.Divide(5, 0));
    }
}