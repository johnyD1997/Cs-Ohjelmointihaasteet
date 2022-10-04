namespace Lihapiirakka
{
    class Program
    {
        public static void Main(string[] args)
        {   
            Console.WriteLine("Write your maney!");
            double money = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Write a price of pie");
            double price = Convert.ToDouble(Console.ReadLine());
            var wallet = new Lompakko(money);

            wallet.Pay(price);
            Console.WriteLine(wallet);
        }

    }

}
