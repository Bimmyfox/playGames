namespace TestTask.Models
{
    public class UserModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public bool IsAdmin { get; set; } // This property determines access
    }
}