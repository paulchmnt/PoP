using System;
using System.Collections.Generic;
using System.Text;
using static Lesson_07.Enums;

namespace Lesson_07
{
    class Car
    {
        private string registrationNumber;
        private Make make;
        private Model model;
        private int year;
        private Colors color;
        private string colorName;


        // Properties   
        public string RegistrationNumber
        {
            get { return registrationNumber; }
            set
            {
                if (value.Length <= 10 && value.Length > 0)
                    registrationNumber = value;
                else
                    throw new ArgumentOutOfRangeException("Registration number must be less than 10 characters!");
            }
        }
        public Make Make { get; set; }
        public Model Model { get; set; }
        public int Year
        {
            get { return year; }
            set
            {
                if (value <= 2050 && value >= 1900)
                    year = value;
                else
                    throw new ArgumentOutOfRangeException("Year must be between 1900 & 2050!");
            }
        }
        public Colors Color { get; set; }
        public string ColorName
        {
            get
            {
                switch (Color)
                {
                    case Colors.Others:
                        return colorName;
                    default:
                        return Color.ToString();    
                }
            }
            set
            {
                if (value.Length > 0 && value.Length <= 10)
                    colorName = value;
                else
                    throw new ArgumentOutOfRangeException("Not a color!");
            }
        }
    }
}
