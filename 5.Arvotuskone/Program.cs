using System;

namespace Arvotuskone
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("User 1, enter the number between 0 and 100: ");
            int number = Convert.ToInt32(Console.ReadLine());
            while(number > 100 || number < 0)
            {
                Console.Write("User 1, enter the number between 0 and 100: ");
                number = Convert.ToInt32(Console.ReadLine());
            }

            Console.Clear();
            
            Console.WriteLine("User 2, quess the number");
            while(true)
            {
                Console.Write("What is your next guess? ");
                int quessNumber = Convert.ToInt32(Console.ReadLine());

                if (quessNumber == number)
                {
                    Console.WriteLine("You guessed the number!");
                    break;
                }
                else if((quessNumber < number && quessNumber >= number - 3)|| (quessNumber > number && quessNumber <= number + 3))
                {
                    Console.WriteLine("You are close!");
                }
                else if(quessNumber < number)
                {
                    Console.WriteLine($"{quessNumber} is too low.");
                }
                else if (quessNumber > number)
                {
                    Console.WriteLine($"{quessNumber} is too high.");
                }
            }

        } 
    }
}
