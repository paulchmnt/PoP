using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_07
{
    public class Enums
    {
        public enum Make
        {
            Toyota,
            Ford,
            Renault,
            Peugeot
        }

        public enum Model
        {
            Civic,
            Camry,
            Corolla,
            Focus,
            Escape,
            Megane,
            _306,
            _3008
        }

        public enum Colors
        {
            Red = 1,
            Blue = 2,
            Yellow = 3,
            Green = 4,
            Purple = 5,
            Black = 6,
            White = 7,
            Orange = 8,
            Brown = 9,
            Others = 0
        }
    }
}
