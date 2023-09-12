using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestTask
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Animal[] animals = new Animal[] { new Animal(), new Horse(), new Cat(), new Dog()}; //Создадим массив животных      
            Vet vet = new Vet(); //Создадим ветеринара

            foreach (Animal animal in animals) //Пройдемся в цикле по всем животным из массива
            {
                vet.TreatAnimal(animal); //Вызовем у ветеринара метод "Лечить животное"
                Console.WriteLine(); //Для удобства отображения добавим пустую строку после каждого животного
            }
        }
    }
}
