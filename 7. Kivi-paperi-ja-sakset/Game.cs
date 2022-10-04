using System.Collections.Generic;
namespace KPS
{
    class Game
    {
        List<string> marks;
        
        string computer = "";
        Random randome = new Random();
        // int index;
        public Game()
        {
            this.marks = new List<string>{"Kivi", "Paperi", "Sakset"}; 
        }

        private string UserChoise()
        {
            int choise = Convert.ToInt32(Console.ReadLine());
            while(choise < 1 || choise > 3)
            {
                choise = Convert.ToInt32(Console.ReadLine());
            }
            string userChoise = marks[choise -1];
            return userChoise;
        }

        private string ComputerCoise()
        {
            int index = randome.Next(marks.Count());
            this.computer = marks[index];
            return computer;
        }

        public void Play()
        {
            Console.WriteLine("1 = Kivi, 2 = Paperi, 3 = Sakset");
            string comp = ComputerCoise();
            string user = UserChoise();
            while (comp == user){
                Console.WriteLine("Try again!");
                user = UserChoise();
                comp = ComputerCoise();
            }
            if ((user == "Kivi" && comp == "Sakset")||
                 (user == "Paper" && comp == "Kivi")||
                 (user == "Sakset" && comp == "Paper"))
                 {
                    Console.WriteLine("You won!");
                 } 
                 else
                 {
                    Console.WriteLine("You lose!");
                 }
        }

    }
}