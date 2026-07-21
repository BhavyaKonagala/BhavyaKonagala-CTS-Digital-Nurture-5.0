using CRUDOperations;
using Microsoft.EntityFrameworkCore;

using var context = new StudentContext();

context.Database.EnsureCreated();

Console.WriteLine("===== CREATE =====");

var student = new Student
{
    Name = "Bhavya",
    Age = 20
};

context.Students.Add(student);
context.SaveChanges();

Console.WriteLine("Student Added Successfully.");

Console.WriteLine();

Console.WriteLine("===== READ =====");

var students = context.Students.ToList();

foreach (var s in students)
{
    Console.WriteLine($"{s.Id} {s.Name} {s.Age}");
}

Console.WriteLine();

Console.WriteLine("===== UPDATE =====");

var updateStudent = context.Students.FirstOrDefault();

if (updateStudent != null)
{
    updateStudent.Age = 21;

    context.SaveChanges();

    Console.WriteLine("Student Updated Successfully.");
}

Console.WriteLine();

Console.WriteLine("===== DELETE =====");

var deleteStudent = context.Students.FirstOrDefault();

if (deleteStudent != null)
{
    context.Students.Remove(deleteStudent);

    context.SaveChanges();

    Console.WriteLine("Student Deleted Successfully.");
}