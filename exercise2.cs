using System;

namespace LABA1C__2._0
{
    class Rectangle
    {
        private double side1;
        private double side2;

        public Rectangle(double sideA, double sideB)
        {
            side1 = sideA;
            side2 = sideB;
        }

        private double CalculateArea()
        {
            return side1 * side2;
        }

        private double CalculatePerimeter()
        {
            return 2 * (side1 + side2);
        }

        public double Area
        {
            get { return CalculateArea(); }                 
        }

        public double Perimeter
        {
            get { return CalculatePerimeter(); }
        }
    }
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите длину первой стороны прямоугольника:");
            double sideA = double.Parse(Console.ReadLine());           //parse - конвертация из строки в double

            Console.WriteLine("Введите длину второй стороны прямоугольника:");
            double sideB = double.Parse(Console.ReadLine());

            Rectangle rectangle = new Rectangle(sideA, sideB);

            Console.WriteLine($"Площадь прямоугольника: {rectangle.Area}");
            Console.WriteLine($"Периметр прямоугольника: {rectangle.Perimeter}");

            Console.ReadKey();
        }
    }
}

