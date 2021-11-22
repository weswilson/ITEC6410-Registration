namespace Registration.Models
{
    public class AuthenticationViewModel
    {
        public bool IsAuthenticated { get; set; }
        public ApplicationUser? ApplicationUser { get; set; }
    }
}
