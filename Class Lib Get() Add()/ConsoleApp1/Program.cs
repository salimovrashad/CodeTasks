using Collection.Entities;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            IntList list = new IntList();
            Console.WriteLine("Say daxil edin: ");
            int count = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{count} eded daxil edin...");
            for (int i = 0; i < count; i++)
            {
                int number = Convert.ToInt32(Console.ReadLine());
                list.Add(number);
            }
            Console.WriteLine("Daxil olunmus ededler...");
            list.Get();
        }
    }
}