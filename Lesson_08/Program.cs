using System;
using Lesson_08.Task_01;
using Lesson_08.Task_02;
using Lesson_08.Task_03;

namespace Lesson_08
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Task 1
            StudentAndTeacherTest test1 = new StudentAndTeacherTest();
            test1.Main();

            // Task 2
            AlbumTest test2 = new AlbumTest();
            test2.Main();
            
            // Task 3
            SquareTest test3 = new SquareTest();
            test3.Main();

            Console.ReadKey();
        }
    }
}
