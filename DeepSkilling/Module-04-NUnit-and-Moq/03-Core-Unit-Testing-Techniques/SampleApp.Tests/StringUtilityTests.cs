using NUnit.Framework;
using SampleApp;

namespace SampleApp.Tests;

[TestFixture]
public class StringUtilityTests
{
    private StringUtility utility = null!;

    [SetUp]
    public void Setup()
    {
        utility = new StringUtility();
    }

    [Test]
    public void Reverse_ShouldReturnReversedString()
    {
        Assert.That(utility.Reverse("Bhavya"), Is.EqualTo("ayvahB"));
    }

    [Test]
    public void Palindrome_ShouldReturnTrue()
    {
        Assert.That(utility.IsPalindrome("madam"), Is.True);
    }

    [Test]
    public void Numbers_ShouldContainFiveElements()
    {
        int[] numbers = utility.GetNumbers();

        Assert.That(numbers.Length, Is.EqualTo(5));
    }

    [Test]
    public void Collection_ShouldContainCSE()
    {
        var departments = utility.GetDepartments();

        Assert.That(departments, Does.Contain("CSE"));
    }

    [Test]
    public void Collection_ShouldHaveFourDepartments()
    {
        var departments = utility.GetDepartments();

        Assert.That(departments.Count, Is.EqualTo(4));
    }

    [Test]
    public void VoidMethod_ShouldAddLog()
    {
        utility.AddLog("Testing");

        Assert.That(utility.GetLogs().Count, Is.EqualTo(1));
    }

    [Test]
    public void Divide_ShouldThrowException()
    {
        Assert.Throws<DivideByZeroException>(() =>
        {
            utility.Divide(10, 0);
        });
    }

    [Test]
    public void Divide_ShouldReturnAnswer()
    {
        Assert.That(utility.Divide(20, 5), Is.EqualTo(4));
    }
}