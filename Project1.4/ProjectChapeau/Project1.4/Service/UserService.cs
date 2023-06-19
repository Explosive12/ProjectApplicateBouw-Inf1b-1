using Microsoft.Graph.Models;
using Project1._4.DAL;
using Project1._4.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
    }
}