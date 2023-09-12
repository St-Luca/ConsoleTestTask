using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestTask
{
    internal class Cat : Animal //Наследование
    {
        /// <summary>
        ///  Уникальные переменные класса Cat
        /// </summary>
        public int furLength;
        public bool isFluffy;
        public Cat() //Конструктор
        {
            food = "Cat food"; //Назначим персонализированные значения для класса Cat
            location = "Cat location";
            furLength = 20;
            isFluffy = true;
        }

        override public void Eat() //Переопределение
        {
            Console.WriteLine($"Cat eat {food}");
        }

        override public void MakeNoise() //Переопределение
        {
            Console.WriteLine("Cat say \"meow\"");
        }
    }
}
