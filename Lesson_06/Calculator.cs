using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_06
{
    class Calculator
    {
        // Fields
        private float valA;
        private float valB;
        private string operation;

        // Constructor
        public Calculator(float valA, float valB, string operation)
        {
            ValA = valA;
            ValB = valB;
            Operation = operation;
        }


        // Properties
        public float ValA
        {
            get { return valA; }
            set
            {
                valA = value;
            }
        }
        public float ValB
        {
            get { return valB; }
            set
            {
                valB = value;
            }
        }
        public string Operation
        {
            get { return operation; }
            set
            {
                if (value == "+" || /*value == "-" || value == "*" ||*/ value == "/")
                    operation = value;
                else
                    throw new ArgumentException("Invalid operation! Enter +, -, * or /");
            }
        }

        public void ToCalculate()
        {
            float calcResult = 0;
            switch (operation)
            {
                case "+":
                    calcResult = valA + valB;
                    break;
                case "/":
                    if (valB == 0)
                        throw new DivideByZeroException("Value B cannot be 0!");
                    else
                        calcResult = valA / valB;
                    break;
            }
            Console.WriteLine($"{valA} {operation} {valB} = {calcResult}");
        }
    }
}
