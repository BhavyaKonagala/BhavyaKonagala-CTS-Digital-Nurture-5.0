using Microsoft.EntityFrameworkCore;

namespace PerformanceDemo;

public class StudentContext : DbContext
{
    public DbSet<Student> Students => Set<Student>();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
            "Server=localhost\\SQLEXPRESS;Database=PerformanceDB;Trusted_Connection=True;TrustServerCertificate=True;");
    }
}