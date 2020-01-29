using System;
using System.Collections.Generic;
using System.Text;

namespace race
{
    class Car
    {
        public string Name { get; set; }
        public int Speed { get; set; }
        public Car(string name,int speed)
        {
            Name = name;
            Speed = speed;
        }
        public Car()
        {

        }
        public override string ToString()
        {
            return $"Название машины:{Name} скорость этой машины={Speed}\n";
        }
    }
}
