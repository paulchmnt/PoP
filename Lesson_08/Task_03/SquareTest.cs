using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_08.Task_03
{
    class SquareTest
    {
        public void Main()
        {
            Square square = new Square();
            square.ToString();
            Console.WriteLine("Perimeter: " + square.GetPerimeter());
            Console.WriteLine("Area: " + square.GetArea());

            Console.WriteLine();

            square.Move(3, 4);
            square.Scale(8);
            square.ToString();
            Console.WriteLine("Perimeter: " + square.GetPerimeter());
            Console.WriteLine("Area: " + square.GetArea());
        }
    }
}
