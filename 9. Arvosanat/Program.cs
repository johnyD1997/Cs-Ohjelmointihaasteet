using System;

namespace Arvosanat
{
    class Program
    {
        public static void Main(string[] args)
        {
          Gradation grades = new Gradation(6);
         Console.WriteLine(grades.ReturnNameOfGrade(4));
        }
    }

    
}

