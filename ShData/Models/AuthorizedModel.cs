namespace ShData.Models
{
    public class AuthorizedModel
    {
        public string Login { get; set; }
        public bool IsAdmin { get; set; }

        public string Email { get; set; }

        public AuthorizedModel(string login, bool isAdmin,string email)
        {
            Login = login;
            IsAdmin = isAdmin;
            Email = email;
        }

        public AuthorizedModel()
        {
            
        }
    }
}
