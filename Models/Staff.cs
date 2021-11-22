namespace Registration.Models
{
    public class Staff : IRole
    {
        public int StaffId { get; set; }
        public string? Name { get; set; }
        public Department? Department { get; set; }
    }
}