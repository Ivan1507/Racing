using System;
using System.Collections.Generic;
using System.Text;

namespace race
{
    class Race:Car
    {
        public Race(Car car1,Car car2)
        {
            if (car1.Speed > car2.Speed) Console.WriteLine($"Победила машина {car1.Name}");
            else Console.WriteLine($"Победила машина {car2.Name}");
        }
    }
}
