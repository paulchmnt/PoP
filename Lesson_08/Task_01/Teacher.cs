using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_08.Task_01
{
    class Teacher : Person
    {
        private string subject;

        public void Explain()
        {
            Console.WriteLine("Explaination begins.");
        }
    }
}
