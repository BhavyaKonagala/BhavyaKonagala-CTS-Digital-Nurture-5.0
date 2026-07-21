using System.Collections.Generic;

namespace DatabaseModel;

public class Department
{
    public int DepartmentId { get; set; }

    public string DepartmentName { get; set; } = string.Empty;

    public ICollection<Student> Students { get; set; } = new List<Student>();
}