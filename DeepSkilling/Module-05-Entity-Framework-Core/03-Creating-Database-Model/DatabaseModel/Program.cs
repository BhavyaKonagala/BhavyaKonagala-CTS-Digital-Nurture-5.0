using DatabaseModel;

Console.WriteLine("Creating Database Model...");

using var context = new StudentContext();

context.Database.EnsureCreated();

Console.WriteLine("Database Created Successfully.");

Console.WriteLine();

Console.WriteLine("Tables Created:");

Console.WriteLine("- Departments");

Console.WriteLine("- Students");

Console.WriteLine();

Console.WriteLine("Relationship:");

Console.WriteLine("One Department -> Many Students");