using System;
namespace ConsoleApp2
{
    class Program
    {
        static void Main()
        {

            Console.Write("Введите длину окружности: ");

            double circumference = double.Parse(Console.ReadLine());

            double radius = circumference / (2 * Math.PI);

            double area = Math.PI * Math.Pow(radius, 2);

            Console.WriteLine("Площадь круга: {0:f3}",+ area);
        }
    }
}
