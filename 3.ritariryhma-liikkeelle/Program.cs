using System;
using System.Collections.Generic;

namespace haaste3
{
    class Program
    {
        private static void Main(string[] args)
        {
            List<Ritari>ritarit = new List<Ritari>();

            Console.Write("Kohde rivi? ");
            var rivi = Convert.ToInt32(Console.ReadLine());

            Console.Write("Kohde sarake? ");
            var sarake = Convert.ToInt32(Console.ReadLine());

            Ritari firstRitari = new Ritari("Ritari yksi", rivi, sarake - 1);
            Ritari secondRitari = new Ritari("Ritari kaksi", rivi -1, sarake);
            Ritari thirdRitari = new Ritari("Ritari kolme", rivi, sarake + 1);
            Ritari fourthRitari = new Ritari("Ritari nelja", rivi + 1, sarake);

            ritarit.Add(firstRitari);
            ritarit.Add(secondRitari);
            ritarit.Add(thirdRitari);
            ritarit.Add(fourthRitari);

            foreach(Ritari ritari in ritarit)
            {
                ritari.Coordinates();
            }
        }
    }

}