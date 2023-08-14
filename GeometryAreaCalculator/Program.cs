using System;
using System.Collections.Generic;
using System.Globalization;
using GeometryAreaCalculator.Entities;
using GeometryAreaCalculator.Entities.Enums;

namespace GeometryAreaCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> list = new List<Shape>();

            Console.Write("Enter the number of shapes: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Shape #{i} data:");
                Console.Write("Rectangle, Circle or Square (r/c/s)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Color (Black/Red/Blue): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());

                if (ch == 'r' ||  ch == 'R')
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine() , CultureInfo.InvariantCulture);
                    list.Add(new Rectangle(width, height, color));
                }

                else if (ch == 'c' ||  ch == 'C')
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Circle(radius, color));
                }

                else
                {
                    Console.Write("Side: ");
                    double side = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Square(side, color));
                }
            }

            Console.WriteLine();
            Console.WriteLine("SHAPE AREAS:");
            foreach(Shape shape in list)
            {
                Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}