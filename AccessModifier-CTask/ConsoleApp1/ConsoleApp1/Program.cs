using ConsoleApp1.Models;

namespace ConsoleApp1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			User user = new User();
			user.Username = "Royal";
			user.Password = "AAAaaa111";
            Console.WriteLine(user.FullName);
        }
	}
}