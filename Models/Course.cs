namespace Registration.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public string Name { get; set; }
        public string CourseNumber { get; set; }
        public int? DepartmentId { get; set; }
        public virtual Department Department { get; set; }
        public string Description { get; set; }
        public ICollection<Student> Students { get; set; }

        public string FullCourseNumber()
        {
            return Department.Prefix + " " + CourseNumber;
        } 
    }
}