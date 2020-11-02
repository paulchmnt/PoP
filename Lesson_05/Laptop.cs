using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_05
{
    class Laptop
    {
        // Fields
        private string model;
        private string manufacturer;
        private string processor;
        private int ram; // in Go
        private string graphicCards;
        private int hdd;
        private string screen;
        private Battery battery;
        private int price;

        // Constructors
        public Laptop(string model, int price)
        { // Constructor with mandatory fields
            Model = model;
            Price = price;
            battery = new Battery();
        }

        public Laptop(string model, int price, int hdd, string batteryModel, int batteryLife)
        { // Constructor with some fields
            Model = model;
            Price = price;
            Hdd = hdd;
            battery = new Battery(batteryModel, batteryLife);
        }
        
        public Laptop(string model, string manufacturer, string processor, int ram, string graphicCards, int hdd, string screen, string batteryModel, int batteryLife, int price)
        { // Constructor with all fields
            Model = model;
            Manufacturer = manufacturer;
            Processor = processor;
            Ram = ram;
            GraphicCards = graphicCards;
            Hdd = hdd;
            Screen = screen;
            battery = new Battery(batteryModel, batteryLife);
            Price = price;
        }

        // Properties
        public string Model
        {
            get { return model; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("Model cannot be empty!");
                model = value;
            }
        }
        public string Manufacturer
        {
            get { return manufacturer; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("Manufacturer cannot be empty!");
                manufacturer = value;
            }
        }
        public string Processor
        {
            get { return processor; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("Processor cannot be empty!");
                processor = value;
            }
        }
        public int Ram
        {
            get { return ram; }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("RAM must be more than 0");

                ram = value;
            }
        }
        public string GraphicCards
        {
            get { return graphicCards; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("Graphic card cannot be empty!");
                graphicCards = value;
            }
        }
        public int Hdd
        {
            get { return hdd; }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("HDD must be more than 0");
                hdd = value;
            }
        }
        public string Screen
        {
            get { return screen; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("Screen cannot be empty!");
                screen = value;
            }
        }
        public int Price
        {
            get { return price; }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Price must be more than 0");

                price = value;
            }
        }

        // Method
        public override string ToString()
        {
            if(hdd == 0 && ram == 0)
                return $"Model: {model}\n" +
                $"Manufacturer: {manufacturer}\n" +
                $"Processor: {processor}\n" +
                $"Gaphic card: {graphicCards}\n" +
                $"Screen model: {screen}\n" +
                $"{battery.ToString()}" +
                $"Price: {price}$";
            else if (ram == 0)
                return $"Model: {model}\n" +
                $"Manufacturer: {manufacturer}\n" +
                $"Processor: {processor}\n" +
                $"Gaphic card: {graphicCards}\n" +
                $"HDD: {hdd} Go\n" +
                $"Screen model: {screen}\n" +
                $"{battery.ToString()}" +
                $"Price: {price}$";
            return $"Model: {model}\n" +
                $"Manufacturer: {manufacturer}\n" +
                $"Processor: {processor}\n" +
                $"RAM: {ram} Go\n" +
                $"Gaphic card: {graphicCards}\n" +
                $"HDD: {hdd} Go\n" +
                $"Screen model: {screen}\n" +
                $"{battery.ToString()}" +
                $"Price: {price}$";

        }

    }
}
