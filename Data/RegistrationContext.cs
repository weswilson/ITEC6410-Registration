using Microsoft.EntityFrameworkCore;
using Registration.Models;

namespace Registration.Data
{
    public class RegistrationContext : DbContext
    {

        public DbSet<Course> Course { get; set; }
        public DbSet<Department> Department { get; set; }
        public DbSet<Staff> Staff { get; set; }
        public DbSet<Student> Student { get; set; }

        public RegistrationContext(DbContextOptions<RegistrationContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>().HasData(new Department { DepartmentId = 1, Name = "Math", Prefix = "MATH" });
            modelBuilder.Entity<Department>().HasData(new Department { DepartmentId = 2, Name = "English", Prefix = "ENGL" });
            modelBuilder.Entity<Department>().HasData(new Department { DepartmentId = 3, Name = "Information Technology", Prefix = "ITEC" });

            modelBuilder.Entity<Course>().HasData(new { CourseId = 1, CourseNumber = "1251", DepartmentId = 1, Name = "Calculus I", Description = "This is the first course in a three-course sequence designed primarily to provide mathematics and science majors with necessary mathematical understanding and skills. Topics include limits, continuity, differentiation of algebraic and trigonometric functions, applications of the derivative, definite and indefinite integrals, the Fundamental Theorem of Calculus, and applications of the integral." });
            modelBuilder.Entity<Course>().HasData(new { CourseId = 2, CourseNumber = "2252", DepartmentId = 1, Name = "Calculus II", Description = "This is the second course in a three-course sequence designed primarily to provide mathematics and natural science majors with necessary mathematical understanding and skills. Topics include differentiation of logarithmic, exponential, and inverse trigonometric functions, techniques of integration, L'Hopital's rule, improper integrals, numerical methods, infinite series, and polar coordinates." });
            modelBuilder.Entity<Course>().HasData(new { CourseId = 3, CourseNumber = "2253", DepartmentId = 1, Name = "Calculus III", Description = "This is the third course in a three-course sequence designed primarily to provide mathematics and natural science majors with necessary mathematical understanding and skills. Topics include vector spaces and analytic geometry in two and three-space, calculus of vector-valued functions, calculus of functions of several variables, and vector analysis." });
            modelBuilder.Entity<Course>().HasData(new { CourseId = 4, CourseNumber = "2260", DepartmentId = 1, Name = "Introduction to Linear Algebra", Description = "This is a matrix-oriented introduction to linear algebra through the study of systems of linear equations, determinants, Euclidean vector spaces, linear transformations, eigenvalues and eigenvectors, and related topics." });
            modelBuilder.Entity<Course>().HasData(new { CourseId = 5, CourseNumber = "2120", DepartmentId = 1, Name = "Discrete Mathematics", Description = "This course is an introduction to discrete mathematics. Selected topics may include sets, logic, proofs, counting, number theory, graph theory, trees, or algorithms." });
            modelBuilder.Entity<Course>().HasData(new { CourseId = 6, CourseNumber = "2270", DepartmentId = 1, Name = "Differential Equations", Description = "A study of ordinary differential equations with emphasis on linear differential equations. Topics include numerical methods, applications, systems of equations, and Laplace transformations. It is highly recommended that students take MATH 2253 and MATH 2260 prior to this course." });
            modelBuilder.Entity<Course>().HasData(new { CourseId = 7, CourseNumber = "1101", DepartmentId = 2, Name = "English Composition I", Description = "This is a composition course focusing on skills required for effective writing in a variety of contexts, with emphasis on exposition, analysis, and argumentation, and also including introductory use of a variety of research skills. Satisfactory placement test score or successful completion of Learning Support English and Reading are required prior to admission to this course." });
            modelBuilder.Entity<Course>().HasData(new { CourseId = 8, CourseNumber = "1102", DepartmentId = 2, Name = "English Composition II", Description = "This is a composition course that develops writing skills beyond the level of proficiency required by ENGL 1101, that emphasizes interpretation and evaluation based on an introduction to fiction, drama, and poetry, and that incorporates a variety of more advanced research methods. An oral communication component may also be required." });
            modelBuilder.Entity<Course>().HasData(new { CourseId = 9, CourseNumber = "2111", DepartmentId = 2, Name = "World Literature I", Description = "This is a survey of important works of world literature from the beginning through the 17th century." });
            modelBuilder.Entity<Course>().HasData(new { CourseId = 10, CourseNumber = "2112", DepartmentId = 2, Name = "World Literature II", Description = "This is a survey of important works of world literature from the mid--seventeenth century to the present." });
            modelBuilder.Entity<Course>().HasData(new { CourseId = 11, CourseNumber = "2215", DepartmentId = 3, Name = "Introduction to Information Technology", Description = "This course uses short projects to introduce the student to the major information technologies of hardware, systems software, networking, web development, software and applications development, systems analysis, digital media, and database. Security and ethical issues as they affect the use of technologies are also discussed." });
            modelBuilder.Entity<Course>().HasData(new { CourseId = 12, CourseNumber = "2260", DepartmentId = 3, Name = "Introduction to Computer Programming", Description = "This course is an introduction to computer programming, logic, design and implementation. Topics include software design, documentation, coding methods, data types, data structures, functions, subroutines and program control structures." });
            modelBuilder.Entity<Course>().HasData(new { CourseId = 13, CourseNumber = "2270", DepartmentId = 3, Name = "Application Development", Description = "This course is an introduction to computer programming, logic, design and implementation. Topics include software design, documentation, coding methods, data types, data structures, functions, subroutines and program control structures." });
            modelBuilder.Entity<Course>().HasData(new { CourseId = 14, CourseNumber = "2320", DepartmentId = 3, Name = "Network Essentials", Description = "This course covers the architecture, function, and configuration of computer hardware and networks, along with basic operating system software function. The students are introduced to network and communications concepts including operational issues surrounding network planning, configuration, monitoring, trouble shooting, and management." });
            modelBuilder.Entity<Course>().HasData(new { CourseId = 15, CourseNumber = "2380", DepartmentId = 3, Name = "Web Development", Description = "This course introduces concepts and practices associated with Web site development. Focus is on site and page design, page layout techniques, styling methods, coding practices, selection of typography, graphics, and multimedia, accessibility issues, site publishing, testing and maintenance, and site marketing." });

            modelBuilder.Entity<Staff>().HasData(new { StaffId = 1, Name = "Alice", DepartmentId = 3});
            modelBuilder.Entity<Staff>().HasData(new { StaffId = 2, Name = "Bob", DepartmentId = 2 });

            modelBuilder.Entity<Student>().HasData(new { StudentId = 1, Name = "Eve" });
            modelBuilder.Entity<Student>().HasData(new { StudentId = 2, Name = "Frank" });
        }
    }
}