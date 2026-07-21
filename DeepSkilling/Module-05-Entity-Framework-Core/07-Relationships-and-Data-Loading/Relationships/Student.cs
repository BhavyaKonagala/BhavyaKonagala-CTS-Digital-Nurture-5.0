namespace Relationships;

public class Student
{
    public int StudentId { get; set; }

    public string Name { get; set; } = string.Empty;

    public int Age { get; set; }

    public int DepartmentId { get; set; }

    public Department? Department { get; set; }
}