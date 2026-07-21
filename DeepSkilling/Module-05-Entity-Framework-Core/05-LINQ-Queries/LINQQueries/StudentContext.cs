using Microsoft.EntityFrameworkCore;

namespace LINQQueries;

public class StudentContext : DbContext
{
    public DbSet<Student> Students => Set<Student>();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
            "Server=localhost\\SQLEXPRESS;Database=LINQStudentDB;Trusted_Connection=True;TrustServerCertificate=True;");
    }
}