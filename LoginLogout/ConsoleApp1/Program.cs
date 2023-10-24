namespace ConsoleApp1
{
    public class Program : User
    {
        static void Main(string[] args)
        {
            User user = new User();
            user.Login();
            user.Login();
            user.Logout();
            user.Logout();
        }
    }
}