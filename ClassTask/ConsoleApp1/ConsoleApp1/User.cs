using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class User
    {
        public string Username;
        public string Password;

        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }

        public void Login(string username, string password)
        {
            Console.WriteLine("istifadəçi hesaba daxil oldu...");
        }
        public void Logout(string username, string password)
        {
            Console.WriteLine("istifadəçi hesabdan çıxış etdi...");
        }
    }
}
