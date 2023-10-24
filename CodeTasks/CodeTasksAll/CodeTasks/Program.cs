namespace CodeTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. 1-den userin daxil etdiyi edede qeder butun 7-e bolunen ededleri ekrana cap edin.
            //Console.WriteLine("Eded daxil edin...");
            //int number = Convert.ToInt32(Console.ReadLine());

            //for (int i = 1; i <= number; i++)
            //{
            //    if (i % 7 ==0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}



            //2. Ededdeki en boyuk reqemi cap edin(for, while).
            //int maxDigit = 0;
            //int number = Convert.ToInt32(Console.ReadLine());

            //for (;number != 0;)
            //{
            //    if (maxDigit < number%10)
            //    {
            //        maxDigit = number % 10;
            //    }
            //    number /= 10;
            //}
            //Console.WriteLine(maxDigit);



            //6.Verilmis 3 reqemli ededin reqemleri cemini tapin.
            //int number = 459;
            //int sum = 0;

            //for (;number != 0;)
            //{
            //    sum += number % 10;
            //    number /= 10;
            //}
            //Console.WriteLine(sum);



            //7. Verilmis 4 reqemli ededi tersine cevirin. 2345 - 5432
            //int number = 4869;
            //int reverse = 0;
            //while (number > 0)
            //{
            //    int qaliq = number % 10;
            //    reverse = reverse * 10 + qaliq;
            //    number = number / 10;
            //}
            //Console.WriteLine(reverse);


            //8. Verilen ededin sagdan birinci ededini tapin.
            //int number = 45216815;
            //Console.WriteLine(number%10);



            ////11. Verilmis stringi tersden capa verin apple-elppa



            //9.Sozdeki sonda ve evvelde olan bosluqlari silin.
            //string word = "  Hello  ";
            //string wordTwo = "";

            //for (int i = 0; i < word.Length; i++)
            //{
            //    if (word[i] != ' ')
            //    {
            //        wordTwo += word[i];
            //    }
            //}
            //Console.WriteLine(wordTwo);



            //12. Polindrom eded olub olmamasi
            //int number = 313;
            //int temporary = number;
            //int reverse = 0;
            //int teklik;

            //do
            //{
            //    teklik = temporary % 10;
            //    reverse = reverse * 10 + teklik;
            //    temporary /= 10;
            //}while (temporary != 0);

            //if (reverse == number)
            //{
            //    Console.WriteLine("Is Polindrom");
            //}
            //else
            //{
            //    Console.WriteLine("Is not Polindrom");
            //}



            //13. Arrayda en boyuk ve en kicik ededi deyis
            //int[] array = { 1, 2, 3, 6, 5, 4 };
            //int j = 0;
            //int k = 0;

            //for (int i = 0; i < array.Length; i++)
            //{
            //    if (array[j] < array[i])
            //    {
            //        j = i;
            //    }
            //    if (array[k] > array[i])
            //    {
            //        k = i;
            //    }
            //}
            //array[j] = array[j] + array[k];
            //array[k] = array[j] - array[k];
            //array[j] = array[j] - array[k];

            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.WriteLine(array[i]);
            //}


            
            //14. Ededde tekrarlanan reqemin olub olmamasi
            //int number = 78568;
            //int temp = number;
            //bool isRepeat = false;

            //while (temp > 0)
            //{
            //    int last = temp % 10;
            //    temp = temp / 10;
            //    int secondTemp = temp;
            //    while (secondTemp > 0)
            //    {
            //        int secondLast = secondTemp % 10;
            //        if (secondLast == last)
            //        {
            //            isRepeat = true;
            //            break;
            //        }
            //        secondTemp /= 10;
            //    }
            //    if (isRepeat)
            //    {
            //        break;
            //    }
            //}
            //Console.WriteLine(isRepeat);



            //15.Ədədin sadə və ya mürəkkəb olduğunu tapan alqoritm yazın.
            //Console.WriteLine("Input the number.");
            //int number = Convert.ToInt32(Console.ReadLine());

            //if (number < 2)
            //{
            //    Console.WriteLine("Number not simple and complex.");
            //}
            //else
            //{
            //    bool isSimple = true;
            //    for (int i = 2; i <= number; i+=2)
            //    {
            //        if (number % i == 0)
            //        {
            //            isSimple = false;
            //            break;
            //        }
            //    }

            //    if (isSimple)
            //    {
            //        Console.WriteLine("Number is simple.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Number is complex.");
            //    }
            //}



            //16.Ededin mertebelerinin sayi
            //int number = 4568;
            //int count = 0;

            //while (number > 0)
            //{
            //    number /= 10;
            //    count++;
            //}
            //Console.WriteLine(count);



            //17. ededin cut ve ya tek olmasi, ve eger reqem duz deyilse davam etsin ya yox
            //string user = "";
            //do
            //{
            //    Console.WriteLine("eded daxil edin");
            //    int i = Convert.ToInt32(Console.ReadLine());
            //    if (i > 10 && i < 20)
            //    {
            //        if (i % 2 == 0)
            //        {
            //            Console.WriteLine("eded cutdur");
            //            break;
            //        }
            //        else
            //        {
            //            Console.WriteLine("eded tekdir");
            //            break;
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("eded duz deyil");
            //        Console.WriteLine("Davam?");
            //        user = Console.ReadLine();
            //    }

            //} while (user == "yes");

        }
    }
}