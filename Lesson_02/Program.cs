using System;

namespace Lesson_02
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task 1
            //MeAfterTen();
            // Task 2
            //SimpleFormulas();
            // Task 3
            //Dates();
            // Task 4

            /*
            // HOMEWORK LESSON 2 TO 3
            // 1.
            Console.WriteLine("Hello\nPaul Chaumont");
            // 2.
            Console.WriteLine("This a program to make a sum of 2 numbers you chose");
            Console.Write("Choose number a > ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Choose number b > ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a + " + " + b + " = " + (a + b));
            // 3.
            */


            Console.ReadKey();
        }

        static void MeAfterTen() // Task 1
        {
            Console.WriteLine("How old are you?");
            try
            {
                int age = int.Parse(Console.ReadLine());
                Console.WriteLine("You will be " + (age + 10) + " years old in 10 years");
            }
            catch { Console.WriteLine("Error"); }
        }

        static void SimpleFormulas() // Task 2
        {
            Console.WriteLine("RECTANGLE");

            Console.Write("Please enter side one: ");
            double sideOne = double.Parse(Console.ReadLine());
            Console.Write("Please enter side two: ");
            double sideTwo = double.Parse(Console.ReadLine());

            double perimeter = sideOne * 2 + sideTwo * 2;
            double area = sideOne * sideTwo;

            Console.WriteLine($"The perimeter of your rectangle is {perimeter} and his area is {area}");
            Console.ReadKey();


            Console.WriteLine("-----\nTRIANGLE");

            Console.Write("Please enter side one: ");
            sideOne = double.Parse(Console.ReadLine());
            Console.Write("Please enter side two: ");
            sideTwo = double.Parse(Console.ReadLine());
            Console.Write("Please enter side three: ");
            double sideThree = double.Parse(Console.ReadLine());
            Console.Write("Please enter height: ");
            double height = double.Parse(Console.ReadLine());

            perimeter = sideOne + sideTwo + sideThree;
            area = sideOne * height / 2.0;

            Console.WriteLine($"Perimeter = {perimeter}\nArea = { area}");
            Console.ReadKey();


            Console.WriteLine("-----\nCIRCLE");

            Console.Write("Please enter radius of the circle: ");
            double radius = double.Parse(Console.ReadLine());
            perimeter = 2 * radius * Math.PI;
            area = Math.PI * radius * radius;

            Console.WriteLine($"Perimeter = {perimeter}\nArea = { area}");
        }

        static void Dates() // Task 3
        {
            DateTime date = DateTime.Now;

            Console.WriteLine("Current date: " + date.ToShortDateString());

            Console.WriteLine("Current time: " + date.ToShortTimeString());

            Console.WriteLine("Date in 10 years: " + date.AddYears(10).ToShortDateString());

            Console.Write("Choose a number of years you want to add to the current date: ");
            int adding = int.Parse(Console.ReadLine());
            Console.WriteLine($"Date in {adding} years: {date.AddYears(adding).ToShortDateString()}");
        }

        static void FutureBirthday() // Task 4
        {
            Console.Write("Current age: ");
            int currentAge = int.Parse(Console.ReadLine());

            Console.Write("Future age: ");
            int futureAge = int.Parse(Console.ReadLine());

            Console.Write("Birthday month: ");
            int bdayMonth = int.Parse(Console.ReadLine());

            Console.Write("Birthday day: ");
            int bdayDay = int.Parse(Console.ReadLine());

            int ageDifference = futureAge - currentAge;
            DateTime date = 


        }
    }
}
