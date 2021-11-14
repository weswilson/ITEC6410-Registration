namespace Registration.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public Department? Department { get; set; }
        public Staff? Professor { get; set; }
    }
}