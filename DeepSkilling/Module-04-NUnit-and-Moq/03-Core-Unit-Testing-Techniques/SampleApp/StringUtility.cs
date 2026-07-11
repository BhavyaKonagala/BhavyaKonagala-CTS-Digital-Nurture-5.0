namespace SampleApp;

public class StringUtility
{
    private readonly List<string> _logs = new();

    public string Reverse(string text)
    {
        return new string(text.Reverse().ToArray());
    }

    public bool IsPalindrome(string text)
    {
        string reverse = Reverse(text);
        return text.Equals(reverse, StringComparison.OrdinalIgnoreCase);
    }

    public int[] GetNumbers()
    {
        return new int[] { 10, 20, 30, 40, 50 };
    }

    public List<string> GetDepartments()
    {
        return new List<string>
        {
            "CSE",
            "ECE",
            "IT",
            "MECH"
        };
    }

    public void AddLog(string message)
    {
        _logs.Add(message);
    }

    public List<string> GetLogs()
    {
        return _logs;
    }

    public int Divide(int a, int b)
    {
        if (b == 0)
            throw new DivideByZeroException();

        return a / b;
    }
}