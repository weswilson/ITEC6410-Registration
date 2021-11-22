namespace Registration.Models
{
    public class Student : IRole
    {
        public int StudentId { get; set; }
        public string? Name { get; set; }

        public ICollection<Course> Courses { get; set; }
    }
}