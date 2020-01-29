using System;

namespace race
{
    class Program
    {
        static void Main(string[] args)
        {
            Car bmv= new Car("BMV",50,79);
            Car lada = new Car("lada",51,75);
            Console.WriteLine(bmv.ToString()+lada.ToString());
            Race race1 = new Race(bmv, lada);
        }
    }
}
