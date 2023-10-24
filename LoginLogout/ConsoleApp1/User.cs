using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class User
    {
        public string Username;
        public string Password;
        public bool isLogin = true;
        public bool isLogout = true;

        public void Login() 
        {
            if (isLogin)
            {
                Console.WriteLine("User giris etdi...");
                isLogin = false;
            }
            else
            {
                Console.WriteLine("User artiq giris edib...");
            }
        }
        public void Logout()
        {
            if (isLogout)
            {
                Console.WriteLine("User cixis etdi...");
                isLogout = false;
            }
            else
            {
                Console.WriteLine("User giris etmeyib...");
            }
        }
    }

}
