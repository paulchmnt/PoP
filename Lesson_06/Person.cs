using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_06
{
    class Person
    {
        private string name;
        private int age;
        private string email;

        public Person(string name, int age, string email)
        {
            Name = name;
            Age = age;
            Email = email;
        }
        public Person(string name, int age) : this(name, age, null) { }


        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("Name cannot be empty!");

                name = value;
            }
        }
        public int Age
        {
            get { return age; }
            set
            {
                if (value < 0 || value > 100)
                    throw new ArgumentOutOfRangeException("Age must be between 0 & 100!");

                age = value;
            }
        }
        public string Email
        {
            get { return email; }
            set
            {
                if (value == null)
                    email = value;
                else if (value != null && !value.Contains('@'))
                    throw new FormatException("Invalid format!");

                email = value;
            }
        }

        public override string ToString()
        {
            if (email != null)
                return $"Person: {Name}, age: {Age}, e-mail: {Email}";
            return $"Person: {Name}, age: {Age}";
        }
    }
}
