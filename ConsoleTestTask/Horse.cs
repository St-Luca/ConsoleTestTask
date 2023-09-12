using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestTask
{
    internal class Horse : Animal //Наследование
    {
        /// <summary>
        ///  Уникальные переменная класса Horse
        /// </summary>
        public string colorOfMane;
        public int lengthOfMane;
        public Horse() //Конструктор
        {
            food = "Horse food"; //Назначим персонализированные значения для класса Horse
            location = "Horse location";
            colorOfMane = "Black";
            lengthOfMane = 32;
        }

        override public void Eat() //Переопределение
        {
            Console.WriteLine($"Horse eat {food}");
        }

        override public void MakeNoise() //Переопределение
        {
            Console.WriteLine("Horse say \"neigh\"");
        }
    }
}
