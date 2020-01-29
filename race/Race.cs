using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace race
{
    class Race:Car
    {
        public Race(Car car1,Car car2)
        {
            car1.Calcul();
            car2.Calcul();
            if (car1.Speed > car2.Speed) Console.WriteLine($"Победил(а) {car1.Name}");
            else Console.WriteLine($"Победил(а) {car2.Name}");
        }
        public void Save_Race()
        {
            string path = @"C:\Users\Иван\Desktop\1.txt";
            using(StreamWriter sw=new StreamWriter(path, true,Encoding.UTF8))
            {
                sw.WriteLine();
            }
        }
       
       
         
    }
}
