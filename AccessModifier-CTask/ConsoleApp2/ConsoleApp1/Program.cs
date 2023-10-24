using ConsoleApp1.Models;

namespace ConsoleApp1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Person user = new Person();
			user.SetSurname("Salimov");
			user.SetAge(20);

            Console.WriteLine(user.FullName);
        }
	}
}