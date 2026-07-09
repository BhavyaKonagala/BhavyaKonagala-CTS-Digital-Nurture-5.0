using System;

class Student
{
    public string Name;
}

class StudentView
{
    public void Display(string name)
    {
        Console.WriteLine("Student Name: " + name);
    }
}

class StudentController
{
    Student model;
    StudentView view;

    public StudentController(Student m, StudentView v)
    {
        model = m;
        view = v;
    }

    public void UpdateView()
    {
        view.Display(model.Name);
    }
}

class Program
{
    static void Main()
    {
        Student student = new Student();
        student.Name = "Bhavya";

        StudentView view = new StudentView();

        StudentController controller = new StudentController(student, view);

        controller.UpdateView();
    }
}