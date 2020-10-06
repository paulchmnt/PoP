using System;

namespace Lesson_02
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task 1
            MeAfterTen();
            // Task 2
            SimpleFormulas();
            // Task 3
            Dates();
            // Task 4
            FutureBirthday();


            // HOMEWORK LESSON 2 TO 3
            // 1.
            Homework1();
            // 2.
            Homework2();
            // 3.
            Homework3();
            // 4.
            Homework4();
            // 5.
            Homework5();
            // 6.
            Homework6();
            // 7.
            Homework7();
            // 8.
            Homework8();
            // 9.
            Homework9();
            // 10.
            Homework10();

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
            int futureYear = ageDifference + DateTime.Today.Year;

            Console.WriteLine($"You will be {futureAge} on {bdayDay} / {bdayMonth} / {futureYear}");
        }

        static void Homework1()
        {
            Console.WriteLine("Hello\nPaul Chaumont");
        }

        static void Homework2()
        {
            Console.WriteLine("This a program to make a sum of 2 numbers you chose");
            Console.Write("Choose integer number a > ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Choose integer number b > ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(a + " + " + b + " = " + (a + b));
        }

        static void Homework3()
        {
            Console.WriteLine($"-1 + 4 * 6 = {-1 + 4 * 6}");
            Console.WriteLine($"(35 + 5) % 7 = {(35 + 5) % 7}");
            Console.WriteLine($"14 + -4 * 6 / 11 = {14 + -4 * 6 / 11}");
            Console.WriteLine($"2 + 15 / 6 * 1 - 7 % 2 = {2 + 15 / 6 * 1 - 7 % 2}");
        }

        static void Homework4()
        {
            Console.Write("Please choose an integer number A > ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Please choose an integer number B > ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Please choose an integer number C > ");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine($"{a} * {b} * {c} = {a * b * c}");
        }

        static void Homework5()
        {
            Console.Write("Please choose an integer number > ");
            int a = int.Parse(Console.ReadLine());
            string[] table = new string[10];
            for (int i =0; i<10; i++)
            {
                table[i] = $"{a} * {i + 1} = {a * (i + 1)}";
            }
            Console.WriteLine($"This is the table of multiplication of {a}:");
            for (int i = 0; i<table.Length; i++)
            {
                Console.WriteLine(table[i]);
            }
        }

        static void Homework6()
        {
            Console.Write("Please choose an integer number A > ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Please choose an integer number B > ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Please choose an integer number C > ");
            int c = int.Parse(Console.ReadLine());
            Console.Write("Please choose an integer number D > ");
            int d = int.Parse(Console.ReadLine());
            Console.WriteLine($"The average of {a}, {b}, {c} and {d} is {(a + b + c + d) /4.0}");
        }

        static void Homework7()
        {
            Console.Write("Please choose an integer number > ");
            int a = int.Parse(Console.ReadLine());
            bool inside = false;
            if (a <= 200 && a >= 100)
                inside = true;
            Console.WriteLine($"{a} is within range between 100 and 200 is {inside}");
        }

        static void Homework8()
        {
            DateTime date = DateTime.Now;
            Console.WriteLine($"Current date : {date.ToShortDateString()}");
        }

        static void Homework9()
        {
            Console.Write("Please enter your age > ");
            int age = int.Parse(Console.ReadLine());
            int yearOfBirth = DateTime.Today.Year - age;
            Console.WriteLine($"You're born in {yearOfBirth}");
        }

        static void Homework10()
        {
            Console.Write("Please choose an integer number x > ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Please choose an integer number y > ");
            int y = int.Parse(Console.ReadLine());
            Console.Write("Please choose an integer number z > ");
            int z = int.Parse(Console.ReadLine());
            Console.WriteLine($"({x} + {y}) * {z} = {(x + y) * z}");
            Console.WriteLine($"{x} * {y} + {y} * {z} = {x * y + y * z}");
        }
    }
}
