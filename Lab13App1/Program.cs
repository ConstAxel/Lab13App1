using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13App1
{
    class Program
    {
        static void Main(string[] args)
        {
            //    Задан класс Building, который описывает здание.Класс содержит следующие элементы:

            //    адрес здания;
            //    длина здания;
            //    ширина здания;
            //    высота здания.
            //В классе Building нужно реализовать следующие методы:

            //    конструктор с 4 параметрами;
            //    свойства get/ set для доступа к полям класса;
            //    метод Print(), который выводит информацию о здании.
            //Разработать класс MultiBuilding, который наследует возможности класса Building и добавляет поле этажность.В классе MultiBuilding реализовать следующие элементы:

            //конструктор с 5 параметрами – реализует вызов конструктора базового класса;
            //    свойство get/ set доступа к внутреннему полю класса;
            //    метод Print(), который обращается к методу Print() базового класса Building для вывода информации о всех полях класса.
            //Класс MultiBuilding сделать таким, что не может быть унаследован.
            Console.WriteLine("Адрес первого здания");
            Building building = new Building("Улица Горького дом 11",124,56,42);
            building.Print();
            Console.WriteLine("\n");
            Console.WriteLine("Адрес второго здания");
            MultiBuilding multiBuilding = new MultiBuilding("Улица Пушкина дом 91", 12, 5, 9,3);
            multiBuilding.Print();
            Console.ReadKey();
        }
        class Building
        {
            public string Address { get; set; }
            public double Lengthbuilding { get; set; }
            public double Widthhbuilding { get; set; }
            public double Heightbuilding { get; set; }
            public Building(string address, double lengthbuilding, double widthhbuilding, double heightbuilding)
            {
                Address = address;
                Lengthbuilding = lengthbuilding;
                Widthhbuilding = widthhbuilding;
                Heightbuilding = heightbuilding;
            }
            public void Print()
            {
                Console.WriteLine($"Адрес здания: \t{Address}");
                Console.WriteLine($"Длина здания: \t{Lengthbuilding}");
                Console.WriteLine($"Ширина здания: \t{Widthhbuilding}");
                Console.WriteLine($"Высота здания: \t{Heightbuilding}");
            }
        }
        sealed class MultiBuilding: Building
        {
            public int Floor { get; set; }
            public MultiBuilding (string address, double lengthbuilding, double widthhbuilding, double heightbuilding, int floor)
                :base (address, lengthbuilding, widthhbuilding, heightbuilding)
            {
                Floor = floor;
            }
            
            public void Print()
            {
                base.Print();
                Console.WriteLine($"Этажность здания:{Floor}");
            }

        }
    }
}
