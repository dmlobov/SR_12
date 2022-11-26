using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    static class Circle
    {
        static public double GetLength(double r)
        {
            return 2 * Math.PI * r;
        }
        static public double GetSquare(double r)
        {
            return Math.PI * r*r;
        }
        static public string GetBelonging(double x, double y, double r)
        {
            if (Math.Sqrt((x * x) + (y * y)) < r)
                return "Точка лежит внутри окружности";
            else
            {
                return "Точка не лежит внутри окружности";
            }
        }
    }
}
