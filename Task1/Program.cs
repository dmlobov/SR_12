using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите радиус окружности");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ведите координаты точки x, y");
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            double lendth = Circle.GetLength(r);
            double square = Circle.GetSquare(r);
            string belongin = Circle.GetBelonging(x, y, r);
            Console.WriteLine("Длина окружности {0:0.00}, площадь круга {1:0.00}", lendth, square);
            Console.WriteLine(belongin);
            Console.ReadKey();


        }
    }
}
