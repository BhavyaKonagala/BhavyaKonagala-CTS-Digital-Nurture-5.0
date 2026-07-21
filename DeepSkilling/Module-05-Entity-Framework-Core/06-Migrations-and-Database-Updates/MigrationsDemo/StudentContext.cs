using Microsoft.EntityFrameworkCore;

namespace MigrationsDemo;

public class StudentContext : DbContext
{
    public DbSet<Student> Students => Set<Student>();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
            "Server=localhost\\SQLEXPRESS;Database=MigrationStudentDB;Trusted_Connection=True;TrustServerCertificate=True;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Student>().HasData(
            new Student
            {
                Id = 1,
                Name = "Bhavya",
                Age = 20
            },
            new Student
            {
                Id = 2,
                Name = "Rahul",
                Age = 22
            });
    }
}