namespace ConsoleApp1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Student first = new Student("Vygfvh", "Sadhjh", "840A2", 18);
			Student second = new Student("Rashad", "Salimov", "840A1", 20);

			Student[] students = { first, second };

            foreach (Student item in students)
            {
                Console.WriteLine(item.Name + " " + item.Surname + " " + item.Group + " " + item.Age);
			}
		}
	}
}