using Microsoft.EntityFrameworkCore;
using UniversityPlatform.Models; // Ensure this matches your namespace
namespace UniversityPlatform.Data;
public class ApplicationDbContext : DbContext {
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {
    }

    public DbSet<Department> Departments { get; set; }
    public DbSet<Instructor> Instructors { get; set; }
    public DbSet<Course> Courses { get; set; }
    public DbSet<Trainee> Trainees { get; set; }
    public DbSet<CrsResult> CrsResults { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // 1. Map Instructor Foreign Keys and Disable Cascade Delete
        modelBuilder.Entity<Instructor>()
            .HasOne(i => i.Department)
            .WithMany(d => d.Instructors)
            .HasForeignKey(i => i.Dept_id)
            .OnDelete(DeleteBehavior.Restrict); 

        modelBuilder.Entity<Instructor>()
            .HasOne(i => i.Course)
            .WithMany(c => c.Instructors)
            .HasForeignKey(i => i.Crs_id)
            .OnDelete(DeleteBehavior.Restrict);

        // 2. Map Course Foreign Key
        modelBuilder.Entity<Course>()
            .HasOne(c => c.Department)
            .WithMany(d => d.Courses)
            .HasForeignKey(c => c.Dept_id)
            .OnDelete(DeleteBehavior.Restrict);

        // 3. Map Trainee Foreign Key
        modelBuilder.Entity<Trainee>()
            .HasOne(t => t.Department)
            .WithMany(d => d.Trainees)
            .HasForeignKey(t => t.Dept_id)
            .OnDelete(DeleteBehavior.Restrict);
            
        // 4. Map CrsResult Foreign Keys
        modelBuilder.Entity<CrsResult>()
            .HasOne(cr => cr.Course)
            .WithMany(c => c.CrsResults)
            .HasForeignKey(cr => cr.Crs_id)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<CrsResult>()
            .HasOne(cr => cr.Trainee)
            .WithMany(t => t.CrsResults)
            .HasForeignKey(cr => cr.Trainee_id)
            .OnDelete(DeleteBehavior.Restrict);
    }
}