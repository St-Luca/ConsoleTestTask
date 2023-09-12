using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestTask
{
    internal class Vet
    {
        public Vet() { }

        /// <summary>
        ///  Метод, который выводит две строки:
        ///  1) Переменную food экземпляра animal
        ///  2) Переменную location экземпляра animal
        /// </summary>
        public void TreatAnimal(Animal animal) 
        {
            Console.WriteLine(animal.food);
            Console.WriteLine(animal.location);
        }
    }
}
