using System.Text;

namespace Dashboard_webAPI
{
    public  static class Settings
    {
        public static string SecretKey = File.ReadAllText(Path.Combine(AppContext.BaseDirectory, "SecretKey.txt"));
    }
}
