using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_08.Task_03
{
    class Square
    {
        // Attributes
        private int x;
        private int y;
        private int sideLength;

        // Constructors
        public Square(int x, int y, int sideLength)
        {
            this.x = x;
            this.y = y;
            this.sideLength = sideLength;
        }
        public Square() : this(0, 0, 1) { }

        // Methods
        public void Move (int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public void Scale (int factor)
        {
            if (factor >= 0)
                sideLength *= factor;
            else
                throw new ArithmeticException("Error! The factor can't be less than 0.");
        }
        public void ToString()
        {
            Console.WriteLine($"Corner ({x}, {y}) - Side {sideLength}");
        }
        public int GetPerimeter()
        {
            return 4 * sideLength;
        }
        public int GetArea()
        {
            return sideLength * sideLength;
        }
    }
}
