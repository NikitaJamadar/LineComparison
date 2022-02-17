using System;
using System.Collections.Generic;
using System.Text;

namespace UC3
{
    class LineComparison
    {
        int X1, X2, Y1, Y2;
        double Length_of_Line;
        public void AcceptLineCoOrdinates()
        {
            Console.WriteLine("Enter your X1,X2,Y1,Y2:");
            X1 = Convert.ToInt32(Console.ReadLine());
            X2 = Convert.ToInt32(Console.ReadLine());
            Y1 = Convert.ToInt32(Console.ReadLine());
            Y2 = Convert.ToInt32(Console.ReadLine());
        }
        public void DisplayLineCoOrdinates(int X1, int X2, int Y1, int Y2)
        {
            Console.WriteLine("Your X1 is: " + X1 + "\nYour X2 is: " + X2 + "\nYour Y1 is: " + Y1 + "\nYour Y2 is: " + Y2);
        }

        public double CalCulateLengthofLine(int X1, int X2, int Y1, int Y2)
        {
            Length_of_Line = Math.Sqrt(Math.Pow((X2 - X1), 2) + Math.Pow((Y2 - Y1), 2));
            return Length_of_Line;
        }
        public static void Result()
        {
            LineComparison lineobject = new LineComparison();
            Console.WriteLine("Enter The First Line Co-Ordinates :");
            lineobject.AcceptLineCoOrdinates();
            Console.WriteLine("The First Line Co-Ordinates are :");
            lineobject.DisplayLineCoOrdinates(lineobject.X1, lineobject.X2, lineobject.Y1, lineobject.Y2);
            lineobject.CalCulateLengthofLine(lineobject.X1, lineobject.X2, lineobject.Y1, lineobject.Y2);
            double Length_of_First_Line = lineobject.Length_of_Line;
            Console.WriteLine("The first line length is :" + Length_of_First_Line);

            Console.WriteLine("Enter The Second Line Co-Ordinates :");
            lineobject.AcceptLineCoOrdinates();
            Console.WriteLine("The Second Line Co-Ordinates are :");
            lineobject.DisplayLineCoOrdinates(lineobject.X1, lineobject.X2, lineobject.Y1, lineobject.Y2);
            lineobject.CalCulateLengthofLine(lineobject.X1, lineobject.X2, lineobject.Y1, lineobject.Y2);
            double Length_of_Second_Line = lineobject.Length_of_Line;
            Console.WriteLine("The second line length is :" + Length_of_Second_Line);

            if (Length_of_First_Line.CompareTo(Length_of_Second_Line) > 0)
            {
                Console.WriteLine("First line is greater than second line");
            }
            else if (Length_of_First_Line.CompareTo(Length_of_Second_Line) < 0)
            {
                Console.WriteLine("first line less than second line ");
            }
            else if (Length_of_First_Line.CompareTo(Length_of_Second_Line) == 0)
            {
                Console.WriteLine("both are equal");
            }
        }
    }
}
