using Microsoft.EntityFrameworkCore;

namespace Relationships;

public class StudentContext : DbContext
{
    public DbSet<Student> Students => Set<Student>();
    public DbSet<Department> Departments => Set<Department>();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
            "Server=localhost\\SQLEXPRESS;Database=RelationshipDB;Trusted_Connection=True;TrustServerCertificate=True;");
    }
}