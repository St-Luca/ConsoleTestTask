using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestTask
{
    internal class Animal
    {
        public string food;
        public string location;

        public Animal() //Конструктор
        {
            food = "Basic Animal food";
            location = "Basic Animal location";
        }

        /// <summary>
        ///  Метод для переопределения в наследниках
        /// </summary>
        public virtual void MakeNoise()
        {
            Console.WriteLine("Animal make some noise");
        }

        /// <summary>
        ///  Метод для переопределения в наследниках
        /// </summary>
        public virtual void Eat()
        {
            Console.WriteLine($"Animal eat {food}");
        }

        public void Sleep()
        {
            Console.WriteLine($"Animal sleep at {location}");
        }
    }
}
