namespace ConsoleApp2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] array = { 14, 21, 7, 8, 2, 16, 9 };

            Console.WriteLine("Input the number: ");
            int number = Convert.ToInt32(Console.ReadLine());
			bool contain = false;
			
			for (int i = 0; i < array.Length; i++)
			{


				if (array[i] == number)
				{
					Console.WriteLine(i);
				}

                


            }
            Console.WriteLine(contain);
        }
	}
}