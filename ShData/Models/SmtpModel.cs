namespace ShData.Models
{
    public class SmtpModel
    {
        public int Id { get; set; }
        public string Smtp { get; set; }
        public int Port { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
    }
}
