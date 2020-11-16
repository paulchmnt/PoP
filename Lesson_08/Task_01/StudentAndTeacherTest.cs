using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_08.Task_01
{
    class StudentAndTeacherTest
    {
        public void Main()
        {
            Person person = new Person();
            person.Say("Hello!");

            Console.ReadLine();

            Student student = new Student();
            student.SetAge(21);
            student.Say("Greeting!");
            student.ShowAge();  
            student.GoToClasses();

            Console.ReadLine();

            Teacher teacher = new Teacher();
            teacher.SetAge(30);
            teacher.Say("Hello!");
            teacher.Explain();
        }
    }
}
