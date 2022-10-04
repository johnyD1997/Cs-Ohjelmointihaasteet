
using System;
namespace haaste3
{
    public class Ritari
    {
        private string name {get; set;}
        private int rivi {get; set;}
        private int sarake {get; set;}
   
        public Ritari(string name, int rivi, int sarake)
        {
            this.name = name;
            this.rivi = rivi;
            this.sarake = sarake;
        }

        public void Coordinates()
        {
            if(this.rivi < 1 || this.rivi > 8 || this.sarake <1 || this.sarake > 8)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{this.name} ei ole tilaa liikkua");
            }
            else{
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{this.name} kohteeseen ({this.rivi}, {this.sarake})");
            }
            // Console.ForegroundColor = ConsoleColor.White;
        }
    }
}