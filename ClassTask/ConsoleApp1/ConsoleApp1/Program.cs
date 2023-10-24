namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User("Rashad", "123456");
            User[] users = {user1};
            bool isLogin = true;

            foreach (User user in users)
            {
                if (isLogin)
                {
                    Console.WriteLine(User.Login(user.username));
                }
                else
                {
                Console.WriteLine(User.Logout(user.username));
                    
                }
            }
        }
    }
}