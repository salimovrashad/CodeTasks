namespace ConsoleApp3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int small = SmallDigit(new int[] { 2, 3, 1, 4, 5 });
			int big = BigDigit(new int[] { 2, 3, 1, 4, 5 });

			Console.WriteLine(small * big);
		}
		static int SmallDigit(params int[] nums)
		{
			int smalldig = nums[0];

			for (int i = 0; i < nums.Length; i++)
			{


				if (nums[i] < smalldig)
				{
					smalldig = nums[i];
				}


			}
			return smalldig;
		}

		static int BigDigit(params int[] nums)
		{
			int bigdigit = nums[0];

			for (int i = 0; i < nums.Length; i++)
			{



				if (nums[i] > bigdigit)
				{
					bigdigit = nums[i];
				}


			}
			return bigdigit;

		}
	}
}