using System;

namespace Lesson_05
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task_01();
            Console.WriteLine();
            //Task_02();
            Console.WriteLine();
            Task_03();
            Console.WriteLine();

            Console.ReadKey();
        }
        static void Task_01() // Class Dog
        {
            Dog dog1 = new Dog
            {
                Name = "Pil",
                Breed = "Fox Terrier"
            };
            Console.WriteLine($"{dog1.Name}, {dog1.Breed}");
            dog1.Bark();
            dog1.Name = "Lip";
            dog1.Breed = "Labrador";
            Console.WriteLine($"{dog1.Name}, {dog1.Breed}");
        }

        static void Task_02() // Class person
        {
            Person person1 = new Person("Jenn", 21);
            Person person2 = new Person("Alex", 20, "alex@gmail.com");
            Person person3 = new Person("Vic", 23, "vic@gmail.com");

            Console.WriteLine(person1.ToString());
            Console.WriteLine(person2.ToString());
            Console.WriteLine(person3.ToString());
        }

        static void Task_03() // Class Laptop
        {
            Laptop laptop = new Laptop("HP-3610", 565);//, 1000, "Alca17", 6);
            Console.WriteLine(laptop.ToString());
            laptop.Hdd = 1000;
            laptop.Ram = 12;
            //laptop.Manufacturer = "";
            Console.WriteLine(laptop.ToString());
        }
    }
}
