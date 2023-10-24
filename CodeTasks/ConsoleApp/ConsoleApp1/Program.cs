namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1
            // int[] nums = {1,2,3,4,5};

            // for(int i=0; i < nums.Length; i++){
            //     Console.WriteLine(nums[i]);
            // }



            //Task 2
            //  int[] nums = {1,2,-3,4,5};
            // int count = 0;
            // for(int i=0; i < nums.Length; i++){

            //     if(nums[i] < 0){
            //         count++;
            //         Console.WriteLine(count);
            //     }

            // }



            //Task3
            // int[] nums = {1,2,3,4,5};
            // int numsCem = 0;
            // for(int i=0; i < nums.Length; i++){

            //     numsCem += nums[i];
            // }
            //     Console.WriteLine(numsCem);


            //Task 4
            //  int[] nums = {-1,-2,3,4,5};
            //  int maxDigit = nums[0];
            //  int minDigit = nums[0];

            //  for(int i=0; i < nums.Length; i++){

            //      if(nums[i] > maxDigit){
            //          maxDigit = nums[i];
            //      }
            //      if(nums[i] < minDigit){
            //          minDigit = nums[i];
            //      }
            //  }
            //     Console.WriteLine(minDigit + maxDigit);



            //Task 5
            
            string user = "";
			do
			{
				Console.WriteLine("eded daxil edin");
				int i = Convert.ToInt32(Console.ReadLine());
				if (i > 10 && i < 20)
                {
					if (i % 2 == 0)
					{
						Console.WriteLine("eded cutdur");
						break;
					}
					else
					{
						Console.WriteLine("eded tekdir");
						break;
					}
				}
                else
                {
					Console.WriteLine("eded duz deyil");
                    Console.WriteLine("Davam?");
                    user = Console.ReadLine();
                }

            } while (user == "yes");
		}
	}
}