using Microsoft.EntityFrameworkCore;
using Registration.Models;

namespace Registration.Data
{
    public class RegistrationContext : DbContext
    {

        public DbSet<Course> Course { get; set; }
        public DbSet<Department> Department { get; set; }
        public DbSet<Staff> Staff { get; set; } 
        //public DbSet<Registration.Models.Schedule> Schedule { get; set; }

        public RegistrationContext(DbContextOptions<RegistrationContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Department>().HasData(new Department { DepartmentId = 1, Name = "Math", Prefix = "MATH" });
            modelBuilder.Entity<Department>().HasData(new Department { DepartmentId = 2, Name = "English", Prefix = "ENGL" });
            modelBuilder.Entity<Department>().HasData(new Department { DepartmentId = 3, Name = "Information Technology", Prefix = "ITEC" });

            modelBuilder.Entity<Course>().HasData(new { CourseId = 1, CourseNumber = "1000", DepartmentId = 1, Name = "Math Fundamentals", Description = "" });
            modelBuilder.Entity<Course>().HasData(new { CourseId = 2, CourseNumber = "1000", DepartmentId = 2, Name = "Introduction to English", Description = "" });
            modelBuilder.Entity<Course>().HasData(new { CourseId = 3, CourseNumber = "1000", DepartmentId = 3, Name = "Introduction to Information Technology", Description = "" });
        }
    }
}