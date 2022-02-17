using System;
using System.Collections.Generic;
using System.Text;

namespace UC1
{
    class LineComparison
    {
        public static void FindLengthOfLine()
        {

            Console.WriteLine("Enter your X1,X2,Y1,Y2:");
            int X1 = Convert.ToInt32(Console.ReadLine());
            int X2 = Convert.ToInt32(Console.ReadLine());
            int Y1 = Convert.ToInt32(Console.ReadLine());
            int Y2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your X1 is: " + X1 + "\nYour X2 is: " + X2 + "\nYour Y1 is: " + Y1 + "\nYour Y2 is: " + Y2);
            double Length_of_line = Math.Sqrt(Math.Pow((X2 - X1), 2) + Math.Pow((Y2 - Y1), 2));
            Console.WriteLine("Your Lenth of line is: " + Length_of_line);
            Console.ReadLine();
        }
    }
}
