using Microsoft.EntityFrameworkCore;

namespace Registration.Data
{
    public class RegistrationContext : DbContext
    {
        public RegistrationContext(DbContextOptions<RegistrationContext> options)
            : base(options)
        {
        }

        public DbSet<Registration.Models.Course> Course { get; set; }
        public DbSet<Registration.Models.Department> Department { get; set; }
    }

}