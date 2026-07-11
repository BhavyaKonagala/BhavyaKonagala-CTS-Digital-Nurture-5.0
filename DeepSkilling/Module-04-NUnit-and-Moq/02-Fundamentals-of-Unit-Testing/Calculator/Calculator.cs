namespace Calculator;

public class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public int Subtract(int a, int b)
    {
        return a - b;
    }

    public bool IsEven(int number)
    {
        return number % 2 == 0;
    }

    public string GetStudentGrade(int marks)
    {
        if (marks >= 90)
            return "A";

        if (marks >= 75)
            return "B";

        if (marks >= 50)
            return "C";

        return "Fail";
    }
}