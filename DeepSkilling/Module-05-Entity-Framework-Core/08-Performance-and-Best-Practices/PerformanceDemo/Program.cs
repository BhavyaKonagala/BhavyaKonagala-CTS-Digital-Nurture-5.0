using Microsoft.EntityFrameworkCore;
using PerformanceDemo;

using var context = new StudentContext();

context.Database.EnsureCreated();

if (!context.Students.Any())
{
    context.Students.AddRange(
        new Student { Name = "Bhavya", Age = 20 },
        new Student { Name = "Rahul", Age = 21 },
        new Student { Name = "Sneha", Age = 19 }
    );

    context.SaveChanges();
}

Console.WriteLine("===== AsNoTracking() =====");

var students = context.Students
                      .AsNoTracking()
                      .ToList();

foreach (var student in students)
{
    Console.WriteLine($"{student.Id} {student.Name} {student.Age}");
}

Console.WriteLine();

Console.WriteLine("===== Batch Insert =====");

var newStudents = new List<Student>
{
    new Student { Name = "Kiran", Age = 22 },
    new Student { Name = "Priya", Age = 20 }
};

context.Students.AddRange(newStudents);

context.SaveChanges();

Console.WriteLine("Batch Insert Completed.");

Console.WriteLine();

Console.WriteLine("Total Students : " + context.Students.Count());