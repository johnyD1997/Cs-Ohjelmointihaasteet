using System;
// using System.Collections.Generic;
namespace vartiotorni
{
    class Program 
    { 
        public static void Main(string[] a)
        {
        int x = Convert.ToInt32(Console.ReadLine());
        int y = Convert.ToInt32(Console.ReadLine());

        Coordinates xy = new Coordinates(x,y);
        Console.WriteLine($"The enemy is to the {xy}!");

        }
    }
}