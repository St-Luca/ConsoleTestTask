using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestTask
{
    internal class Dog: Animal //Наследование
    {
        /// <summary>
        ///  Уникальные переменные класса Dog
        /// </summary>
        public bool hasABone;
        public bool isAGoodBoy;
        public Dog() //Конструктор
        {
            food = "Dog food"; //Назначим персонализированные значения для класса Dog
            location = "Dog location";
            hasABone = true;
            isAGoodBoy = true;
        }

        override public void Eat() //Переопределение
        {
            Console.WriteLine($"Dog eat {food}");
        }

        override public void MakeNoise() //Переопределение
        {
            Console.WriteLine("Dog say \"woof\"");
        }
    }
}
