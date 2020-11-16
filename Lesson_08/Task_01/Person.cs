using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_08.Task_01
{
    class Person
    {
        internal int age;

        public void SetAge(int age)
        {
            this.age = age;
        }
        public void Say(string message)
        {
            Console.WriteLine(message);
        }
    }
}
