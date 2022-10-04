
using System;
namespace vartiotorni
{
    public class Coordinates
    {
        int x {get; set;}
        int y {get; set;}

        string ns = "";
        string we = "";

        public Coordinates(int x, int y)
        {
            this.x = x;
            this.y = y;
            
            ns = y > 0 ? "north" : "south"; 
            we = x > 0 ? "east" : "west";
        }

       
        public override string ToString()
        {
            if (x == 0 && y == 0)
            {
                return "rigth here";
            }
            if (x == 0)
            {
                return ns;
            }
            if (y == 0)
            {
                return we;
            }
            return $"{ns} {we}";
        }

    }
}