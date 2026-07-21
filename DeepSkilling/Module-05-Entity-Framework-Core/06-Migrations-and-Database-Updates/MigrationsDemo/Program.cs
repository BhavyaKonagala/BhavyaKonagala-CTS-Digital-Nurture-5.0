using MigrationsDemo;

using var context = new StudentContext();

Console.WriteLine("Entity Framework Core Migrations Demo");

Console.WriteLine();

Console.WriteLine("Students in Database:");

foreach (var student in context.Students.ToList())
{
    Console.WriteLine($"{student.Id} {student.Name} {student.Age}");
}