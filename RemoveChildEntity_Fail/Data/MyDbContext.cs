using Microsoft.EntityFrameworkCore;
using RemoveChildEntity.Models;

namespace RemoveChildEntity.Data;

public class MyDbContext : DbContext
{
    private DbSet<Course> Courses { get; set; } 
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=myDatabase.db");
    }
}