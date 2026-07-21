using Microsoft.EntityFrameworkCore;

namespace EFSetup;

public class StudentContext : DbContext
{
    public DbSet<Student> Students => Set<Student>();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
            "Server=localhost\\SQLEXPRESS;Database=StudentDB;Trusted_Connection=True;TrustServerCertificate=True;");
    }
}