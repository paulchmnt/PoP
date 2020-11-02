using System;
using System.Collections.Generic;
using System.Globalization;

namespace Lesson_06
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task 1
            Persons();
            Console.WriteLine();

            // Task 2
            Calculator();
            Console.WriteLine();


            Console.ReadKey();
        }

        static void Persons() // Task 1
        {
            // Create a list
            List<Person> list = new List<Person>();
            Person person1 = new Person("Jenn", 21);
            Person person2 = new Person("Alex", 20, "alex@gmail.com");
            Person person3 = new Person("Vic", 23, "vic@gmail.com");


            int choice;
            while (true)
            {
                Console.WriteLine("Please choose:\n\t1. Insert a person in the list\n\t2. Display the list");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        try
                        {
                            Console.Write("Name > ");
                            string name = Console.ReadLine();
                            Console.Write("Age > ");
                            int age = int.Parse(Console.ReadLine());
                            Console.Write("Email > ");
                            string email = Console.ReadLine();

                            Person person;
                            if (email != null)
                                person = new Person(name, age, email);
                            else
                                person = new Person(name, age);
                            list.Add(person);
                        }
                        catch(Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;

                    case 2:
                        foreach (Person pers in list)
                            Console.WriteLine(pers.ToString());
                        break;
                    case 3:
                        goto breakOut;
                }
            }
        breakOut:;

        }

        static void Calculator() // Task 2
        {
            while (true)
            {
                try
                {
                    Console.Write("Value A > ");
                    float valA = float.Parse(Console.ReadLine());
                    Console.Write("Value B > ");
                    float valB = float.Parse(Console.ReadLine());
                    Console.Write("Operation > ");
                    string operation = Console.ReadLine();

                    Calculator calcul = new Calculator(valA, valB, operation);
                    calcul.ToCalculate();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
