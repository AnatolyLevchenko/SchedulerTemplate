namespace ShData.Models
{
    public class LoginModel
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public int IsAdmin { get; set; }

        public LoginModel(string login,string password,bool isAdmin)
        {
            this.Login = login;
            this.Password = password;
            if (isAdmin)
                this.IsAdmin = 1;
        }

        public LoginModel()
        {
            
        }

        public bool IsValid => !string.IsNullOrWhiteSpace(Login) && !string.IsNullOrWhiteSpace(Password) && Login.Length > 3 &&
                               Password.Length > 3;
    }
}
