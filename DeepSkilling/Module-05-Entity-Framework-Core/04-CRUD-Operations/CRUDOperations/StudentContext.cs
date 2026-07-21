using Microsoft.EntityFrameworkCore;

namespace CRUDOperations;

public class StudentContext : DbContext
{
    public DbSet<Student> Students => Set<Student>();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
            "Server=localhost\\SQLEXPRESS;Database=CRUDStudentDB;Trusted_Connection=True;TrustServerCertificate=True;");
    }
}