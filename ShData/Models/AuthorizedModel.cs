namespace ShData.Models
{
    public class AuthorizedModel
    {
        public string Login { get; set; }
        public bool IsAdmin { get; set; }

        public AuthorizedModel(string login, bool isAdmin)
        {
            Login = login;
            IsAdmin = isAdmin;
        }

        public AuthorizedModel()
        {
            
        }
    }
}
