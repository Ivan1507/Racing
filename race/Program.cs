using System;

namespace race
{
    class Program
    {
        static void Main(string[] args)
        {
            Car bmv= new Car("BMV",70);
            Car lada = new Car("lada", 75);
            Console.WriteLine(bmv.ToString()+lada.ToString());
            Race race1 = new Race(bmv, lada);
        }
    }
}
