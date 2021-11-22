namespace Registration.Models
{
    public class ApplicationUser
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public int RoleId { get; set; }
    }
}
