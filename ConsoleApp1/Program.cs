using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите x");

            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите y");

            double y = Convert.ToDouble(Console.ReadLine());

            double g = x - Math.Pow(10, Math.Sin(x)) + Math.Cos(x - y);

            Console.WriteLine("g = {0:f2}", g);

        }
    }
}
