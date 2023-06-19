using System.Configuration;
using System.Security.Cryptography;
using System.Text;


namespace Project1._4
{
    public static class PasswordHasher
    {
        public static string HashPassword(string password)
        {
            string salt = ConfigurationManager.AppSettings["Salt"];
            SHA256 hash = SHA256.Create();
            byte[] passwordbytes = Encoding.UTF8.GetBytes(password + salt);
            byte[] hashedpassword = hash.ComputeHash(passwordbytes);
            return Convert.ToBase64String(hashedpassword);
        }
    }
}

