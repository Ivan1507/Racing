using System;
using System.Collections.Generic;
using System.Text;

namespace race
{
    class Car
    {
        public string Name { get; set; }
        public int Torque { get; set; }
        public double Power { get; set; }
        public double Speed { get; set; }
        public Car(string name,int torgue,double power)
        {
            Name = name;
            Torque=torgue;
            Power = power;
        }
        public Car()
        {

        }
        public override string ToString()
        {
            return $"Название машины:{Name} мощность этой машины={Power} с крутящим моментом={Torque}\n";
        }
        public string Print_Speed()
        {
            return $"Скорость авто={Speed}\n";
        }
        public void Calcul()
        {
            Speed = 1.5 * Power + 1.2 * Torque;
        }
    }
}
