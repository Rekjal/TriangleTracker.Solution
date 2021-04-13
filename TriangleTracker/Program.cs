using System;
using TriangleTracker.Models;

namespace TriangleTracker
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter your first number:");
            string stringSide1 = Console.ReadLine();
            int side1 = int.Parse(stringSide1);

            Console.WriteLine("Enter your second number:");
            string stringSide2 = Console.ReadLine();
            int side2 = int.Parse(stringSide2);

            Console.WriteLine("Enter your third number:");
            string stringSide3 = Console.ReadLine();
            int side3 = int.Parse(stringSide3);

            //   int x = 3
            Triangle objectName = new Triangle();
            string output = objectName.TriangleChecker(side1, side2, side3);
            Console.WriteLine(output);
            //   when you have an object and the parent class of object contains anything (Field or a method)
            //it can be accessed using "dot" operator. COndition is the field/method has to be "public"

        }
    }
}