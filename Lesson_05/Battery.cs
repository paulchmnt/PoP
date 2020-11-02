using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_05
{
    class Battery
    {
        // Fields
        private string batteryModel;
        private int batteryLife; // in hours

        // Constructor
        public Battery() { }
        public Battery(string batteryModel, int batteryLife)
        {
            BatteryModel = batteryModel;
            BatteryLife = batteryLife;

        }

        // Properties
        public string BatteryModel
        {
            get { return batteryModel; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("Battery model cannot be empty!");

                batteryModel = value;
            }
        }
        public int BatteryLife
        {
            get { return batteryLife; }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Battery life must be more than 0");

                batteryLife = value;
            }
        }

        // Method
        public override string ToString()
        {
            if (batteryModel == null && batteryLife == 0)
                return null;

            return $"Battery model: {batteryModel}\n" +
                $"Battery life: {batteryLife}\n";
        }
    }
}
