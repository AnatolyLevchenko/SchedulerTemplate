namespace ShData.Models
{
    public class LoginModel
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public int IsAdmin { get; set; }

        public string Email { get; set; }

        public bool Admin => IsAdmin == 1;

        public LoginModel(string login,string password,bool isAdmin,string email)
        {
            this.Login = login;
            this.Password = password;
            this.Email = email;

            if (isAdmin)
                this.IsAdmin = 1;
        }

        public LoginModel()
        {
            
        }

        public bool IsValid => !string.IsNullOrWhiteSpace(Login) && !string.IsNullOrWhiteSpace(Password) && Login.Length > 3 &&
                               Password.Length > 3;

        public string ChangePassword => "Change";

        public string MakeAdmin { get; set; }



    }
}
