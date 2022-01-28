namespace Infrastructure.Settings
{
    public class Appsettings
    {
        public string Url { get; set; }
        public int Timeout { get; set; } = 3;
        public string Login { get; set; }
        public string Password { get; set; }
    }
}