
using Microsoft.Graph.Models;
using Microsoft.Graph.Models.Security;
using Project1._4.Model;
using Project1._4.Service;
using Project1._4.UI;
using Project1._4.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace Project1._4.Service
{
    public class UserService
    {
        private UserDoa userdao;
        public UserService()
        {
            userdao = new UserDoa();
        }
        public Login LoginUser(string hash, string username)
        {
            return userdao.LoginUser(hash , username);
        }
        public string HashPassword(string password)
        {
            string salt = ConfigurationManager.AppSettings["Salt"];
            SHA256 hash = SHA256.Create();
            byte[] passwordbytes = Encoding.UTF8.GetBytes(password + salt);
            byte[] hashedpassword = hash.ComputeHash(passwordbytes);
            return Convert.ToBase64String(hashedpassword);
        }
    }
}