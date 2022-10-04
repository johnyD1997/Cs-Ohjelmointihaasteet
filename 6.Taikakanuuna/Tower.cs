namespace Taikakanuuna
{
    class Tower 
    {
        int numberOfShoots;
        public Tower(int numberOfShoots)
        {
            this.numberOfShoots = numberOfShoots;
        }

        public void Shoot(int fire, int electric)
        {
            for (int i = 1; i <= numberOfShoots; i++)
            {
                if (i % fire == 0 && i % electric == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"{i}: Electric and Fire");
                }
                else if (i % electric == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"{i}: Electric");
                }
                else if (i % fire == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{i}: Fire");
                }
                else
                {   
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine($"{i}: Normal");
                }
            }
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine ("Recharge!");
            Console.ForegroundColor = ConsoleColor.White;
        }

    }
}