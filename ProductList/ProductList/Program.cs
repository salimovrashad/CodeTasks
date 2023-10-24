namespace ProductList
{

    class Product
    {
        public string Name;
        public int Price;
        public string Description;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Say daxil edin: ");
            int say = int.Parse(Console.ReadLine());

            Product[] products = new Product[say];
            int i= 0;
            Product prd;

            do
            {
                prd = new Product();

                Console.WriteLine("Mehsul adi: ");
                prd.Name = Console.ReadLine();

                Console.WriteLine("Mehsul qiymeti: ");
                prd.Price = int.Parse(Console.ReadLine());

                Console.WriteLine("Mehsul veziyyet: ");
                prd.Description = Console.ReadLine();

                products[i] = prd;
                i++;

            } while (i < say);

            for (int j = 0; j < products.Length; j++)
            {
                Console.WriteLine($"ad: {products[j].Name} qiymeti: {products[j].Price} veziyyeti: {products[j].Description}");
            }

        }
    }
}