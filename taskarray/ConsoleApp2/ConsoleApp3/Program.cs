namespace ConsoleApp3
{
	internal class Program
	{
		//static void Main(string[] args)
		//{
		//          Console.WriteLine(Number(56));
		//      }
		//static string Number(int number)
		//{
		//	string success = "";
		//	if (number % 2 == 0)
		//	{
		//		success = "Number is complex";
		//	}
		//	else
		//	{
		//		success = "Number is single";
		//	}
		//	return success;
		//}

		//static void Main(string[] args)
		//{
		//	int sum = Sum(8, 4);
		//	int diff = Difference(8, 4);
		//	int multi = Multiplication(8, 4);
		//	int divis = Division(8, 4);

		//	Console.WriteLine(sum);
		//	Console.WriteLine(diff);
		//	Console.WriteLine(multi);
		//	Console.WriteLine(divis);
		//}
		//static int Sum(int number1, int number2)
		//{
		//	int sum = number1 + number2;
		//	return sum;
		//}
		//static int Difference(int number1, int number2)
		//{
		//	int diff = number1 - number2;
		//	return diff;
		//}
		//static int Multiplication(int number1, int number2)
		//{
		//	int multi = number1 * number2;
		//	return multi;
		//}
		//static int Division(int number1, int number2)
		//{
		//	int division = number1 / number2;
		//	return division;
		//}


		static void Main(string[] args)
		{
			Number(36);
		}
		static void Number(int number)
		{
			for (int i = 2; i < number;)
			{
                if (number % i == 0)
                {
					Console.WriteLine(i);
					number /= i;
                }
                else
                {
					i++;
                }

            }
		}
	}
}