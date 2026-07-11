using NUnit.Framework;
using Calculator;

namespace Calculator.Tests;

[TestFixture]
public class CalculatorTests
{
    private Calculator calculator = null!;

    [SetUp]
    public void Setup()
    {
        calculator = new Calculator();
    }

    [TearDown]
    public void TearDown()
    {
        calculator = null!;
    }

    [Test]
    public void Add_ShouldReturnCorrectSum()
    {
        Assert.That(calculator.Add(10, 20), Is.EqualTo(30));
    }

    [Test]
    public void Subtract_ShouldReturnCorrectDifference()
    {
        Assert.That(calculator.Subtract(30, 10), Is.EqualTo(20));
    }

    [TestCase(2, true)]
    [TestCase(5, false)]
    [TestCase(10, true)]
    [TestCase(11, false)]
    public void IsEven_TestCases(int number, bool expected)
    {
        Assert.That(calculator.IsEven(number), Is.EqualTo(expected));
    }

    [TestCase(95, "A")]
    [TestCase(80, "B")]
    [TestCase(60, "C")]
    [TestCase(30, "Fail")]
    public void Grade_TestCases(int marks, string expected)
    {
        Assert.That(calculator.GetStudentGrade(marks), Is.EqualTo(expected));
    }

    [Ignore("Example of Ignore Attribute")]
    [Test]
    public void Ignore_Test()
    {
        Assert.Fail();
    }
}