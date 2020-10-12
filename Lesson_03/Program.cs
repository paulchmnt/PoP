using System;

namespace Lesson_03
{
    class Program
    {
        static void Main(string[] args)
        {
            // TASKS
            //Triangles(); // Task 1
            //Numbers(); // Task 2
            //NumbersBis();
            //SportSelector(); // Task 3
            //Greeting(); // Task 4

            // HOMEWORK
            FormValidation(); // Task 5


            Console.ReadKey();
        }

        static void Triangles() // Task 1
        {
            Console.WriteLine("You will enter 3 sides of a triangle (integer numbers):");
            Console.Write("Please enter side A > ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Please enter side B > ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Please enter side C > ");
            int c = int.Parse(Console.ReadLine());

            if (a == b && b == c)
            {
                Console.WriteLine("3 of the sides of the triangle are equal : side A, side B & side C");
            }
            else if (a == b || b == c || a == c)
            {
                Console.Write("2 of the sides of the triangle are equal : ");
                if (a == b)
                    Console.WriteLine("side A & side B");
                else if (b == c)
                    Console.WriteLine("side B & side C");
                else
                    Console.WriteLine("side A & side C");
            }
            else
                Console.WriteLine("The 3 sides of the triangle are different");
        }


        static void Numbers() // Task 2
        {
            Console.WriteLine("How many random numbers do you want to generate (1 to 10):");
            int size = int.Parse(Console.ReadLine());
            

            Random r = new Random();
            int[] array = new int[size];
            int i = 0; int counter = 0; int sum = 0;


            while (i < size)
            {
                array[i] = r.Next(1, 26);
                i++;
            }


            Console.WriteLine("\nThese are the numbers that have been generated:");
            for (i = 0; i<size; i++)
            {
                Console.Write($"{array[i]}  ");
                if (array[i] >= 10 && array[i] <= 20)
                {
                    counter++;
                    sum += array[i];
                }
            }

            Console.WriteLine($"\nThere are {counter} numbers between 10 and 20 and their sum is equal to {sum}");
        }

        static void NumbersBis()
        {
            int counter = 0; int sum = 0; int i = 0; int number;
            Console.WriteLine("How many numbers do you want to enter (until 10):");
            int size = int.Parse(Console.ReadLine());
            while (i != size)
            {
                Console.Write("Please choose a number > ");
                number = int.Parse(Console.ReadLine());

                if (number >= 10 && number <= 20)
                {
                    counter++;
                    sum += number;
                }

                i++;
            }

            Console.WriteLine($"\nThere are {counter} numbers between 10 and 20 and their sum is equal to {sum}");
        }


        static void SportSelector() // Task 3
        {
            Console.Write("Please enter your height (in centimeters) > ");
            int height = int.Parse(Console.ReadLine());

            if (height > 190)
                Console.WriteLine("You should choose to play basketball!");
            else if (height < 175)
                Console.WriteLine("You should choose to do some horse riding!");
            else
                Console.WriteLine("You should choose athletics!");
        }


        static void Greeting() // Task 4
        {
            Console.WriteLine("Please enter a day of the week (number between 1 and 7):");
            int day = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter an hour (number between 0 and 23):");
            int hour = int.Parse(Console.ReadLine());

            string daysBeforeWeekend;
            int daysBeforeWeekendBis = 6 - day;
            if (daysBeforeWeekendBis == 0 || daysBeforeWeekendBis == -1)
                daysBeforeWeekend = "Weekend is here!";
            else if (daysBeforeWeekendBis == 1)
                daysBeforeWeekend = "Weekend is tomorrow!";
            else
                daysBeforeWeekend = $"Weekend is coming in {daysBeforeWeekendBis} days.";
            
            Console.WriteLine($"Good {PartOfTheDay(hour)}, it is a lovely {DayOfTheWeek(day)} today. {daysBeforeWeekend}");
        }

        static string DayOfTheWeek(int day)
        {
            switch (day)
            {
                case 1: return "Monday";
                case 2: return "Tuesday";
                case 3: return "Wednesday";
                case 4: return "Thursday";
                case 5: return "Friday";
                case 6: return "Saturday";
                case 7: return "Sunday";
                default: return "Error";
            }
        }

        static string PartOfTheDay(int hour)
        {
            switch (hour)
            {
                case 6:
                case 7:
                case 8:
                case 9:
                case 10:
                case 11:
                case 12:
                    return "morning";
                case 13:
                case 14:
                case 15:
                case 16:
                case 17:
                case 18:
                    return "afternoon";
                case 19:
                case 20:
                case 21:
                case 22:
                    return "evening";
                default: return "night";
            }
        }


        static void FormValidation() // Task 5
        {
            Console.WriteLine("You will enter some information to complete your form:");

            string firstName, lastName, studentNumber; DateTime dateOfBirth = new DateTime(); 


            bool check = false;
            do
            {
                Console.Write("Please enter your first name > ");
                firstName = Console.ReadLine();
                if (firstName.Length <= 100)
                    check = true;
                else
                    Console.WriteLine("\nError! Your first name is above 100 characters.");
            } while (check == false);


            check = false;
            do
            {
                Console.Write("Please enter your last name > ");
                firstName = Console.ReadLine();
                if (firstName.Length <= 100)
                    check = true;
                else
                    Console.WriteLine("\nError! Your last name is above 100 characters.");
            } while (check == false);


            check = false;
            do
            {
                
            } while (check == false);
        }
    }
}
