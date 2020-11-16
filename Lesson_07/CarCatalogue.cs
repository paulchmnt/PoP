    using System;
using System.Collections.Generic;
using System.Text;
using static Lesson_07.Enums;

namespace Lesson_07
{
    public class CarCatalogue<T>
    {
        private List<T> items;
        private Dictionary<Make, List<Model>> makeModels = new Dictionary<Make, List<Model>>();

        public CarCatalogue()
        {
            items = new List<T>();  

            makeModels.Add(Make.Ford, new List<Model> { Model.Escape, Model.Focus });
            makeModels.Add(Make.Toyota, new List<Model> { Model.Camry, Model.Corolla, Model.Civic });
            makeModels.Add(Make.Peugeot, new List<Model> { Model._306, Model._3008 });
            makeModels.Add(Make.Renault, new List<Model> { Model.Megane });
        }

        public List<T> Items { get; set; }
        public Dictionary<Make, List<Model>> MakeModels { get; set; }

        public static void AddCar()
        {
            Console.WriteLine("Please enter a registration number:");
            string registrationNumber = Console.ReadLine();
            Console.Write("Please enter a make > ");
            Make make = Console.ReadLine();
        }
    }
}
