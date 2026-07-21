using Microsoft.EntityFrameworkCore;
using Relationships;

using var context = new StudentContext();

context.Database.EnsureCreated();

if (!context.Departments.Any())
{
    var department = new Department
    {
        DepartmentName = "Computer Science"
    };

    context.Departments.Add(department);
    context.SaveChanges();

    context.Students.AddRange(
        new Student
        {
            Name = "Bhavya",
            Age = 20,
            DepartmentId = department.DepartmentId
        },
        new Student
        {
            Name = "Rahul",
            Age = 21,
            DepartmentId = department.DepartmentId
        });

    context.SaveChanges();
}

Console.WriteLine("===== EAGER LOADING =====");

var departments = context.Departments
                         .Include(d => d.Students)
                         .ToList();

foreach (var department in departments)
{
    Console.WriteLine($"Department : {department.DepartmentName}");

    foreach (var student in department.Students)
    {
        Console.WriteLine($"   {student.Name} ({student.Age})");
    }

    Console.WriteLine();
}