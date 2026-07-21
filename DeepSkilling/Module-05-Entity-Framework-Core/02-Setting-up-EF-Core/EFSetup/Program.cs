using EFSetup;

Console.WriteLine("Entity Framework Core Setup");

using var context = new StudentContext();

Console.WriteLine("Database Connection Successful.");

Console.WriteLine("Creating Database...");

context.Database.EnsureCreated();

Console.WriteLine("Database Created Successfully.");