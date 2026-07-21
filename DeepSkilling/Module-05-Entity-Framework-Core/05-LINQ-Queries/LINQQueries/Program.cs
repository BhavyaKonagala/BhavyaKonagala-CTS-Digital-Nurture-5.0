using LINQQueries;

using var context = new StudentContext();

context.Database.EnsureCreated();

if (!context.Students.Any())
{
    context.Students.AddRange(
        new Student { Name = "Bhavya", Age = 20, Marks = 92 },
        new Student { Name = "Rahul", Age = 22, Marks = 81 },
        new Student { Name = "Sneha", Age = 19, Marks = 95 },
        new Student { Name = "Kiran", Age = 21, Marks = 76 }
    );

    context.SaveChanges();
}

Console.WriteLine("===== WHERE =====");

var adults = context.Students
                    .Where(s => s.Age >= 20)
                    .ToList();

foreach (var student in adults)
{
    Console.WriteLine($"{student.Name} {student.Age}");
}

Console.WriteLine();

Console.WriteLine("===== SELECT =====");

var names = context.Students
                   .Select(s => s.Name)
                   .ToList();

foreach (var name in names)
{
    Console.WriteLine(name);
}

Console.WriteLine();

Console.WriteLine("===== ORDER BY =====");

var ordered = context.Students
                     .OrderByDescending(s => s.Marks)
                     .ToList();

foreach (var student in ordered)
{
    Console.WriteLine($"{student.Name} {student.Marks}");
}

Console.WriteLine();

Console.WriteLine("===== AGGREGATE =====");

Console.WriteLine($"Average Marks : {context.Students.Average(s => s.Marks)}");

Console.WriteLine($"Highest Marks : {context.Students.Max(s => s.Marks)}");

Console.WriteLine($"Total Students : {context.Students.Count()}");