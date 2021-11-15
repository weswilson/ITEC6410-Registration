using Microsoft.EntityFrameworkCore;
using Registration.Data;

namespace Registration.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RegistrationContext(serviceProvider.GetRequiredService<DbContextOptions<RegistrationContext>>()))
            {
                if (context.Course.Any())
                {
                    return;
                }

                context.Department.AddRange(
                    new Department
                    {
                        Name = "Math"
                    },
                    new Department
                    {
                        Name = "Science"
                    },
                    new Department
                    {
                        Name = "English"
                    }
                );

                context.Course.AddRange(
                    new Course
                    {
                        Name = "ENGL 101"
                    },
                    new Course
                    {
                        Name = "MATH 101"
                    }
                );

                context.SaveChanges();
            }
        }
    }
}