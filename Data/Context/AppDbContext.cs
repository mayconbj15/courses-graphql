using Courses.GraphQL.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Courses.GraphQL.Data.Context;

public class AppDbContext : DbContext
{
    public DbSet<Course> Courses { get; set; }
    public DbSet<Review> Reviews { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> context) : base(context)
    {

    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseNpgsql();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Course>().Property(c => c.Id).ValueGeneratedOnAdd();
        modelBuilder.Entity<Review>().Property(c => c.Id).ValueGeneratedOnAdd();

        base.OnModelCreating(modelBuilder);
    }
}
