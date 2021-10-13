using System;

namespace Tashoglo_13_lab_2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координаты x:");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите координату y:");
            double y = double.Parse(Console.ReadLine());
            if (y == x * x - 2 && y <= -x + 2 && y >= x)Console.WriteLine("Точка попадает в область");
            else Console.WriteLine("Точка не попадает в область");






         
        }
    }
}
