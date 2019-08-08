using System;
using DLLFigureAbstractArea.Entities.Enums;
using DLLFigureAbstractArea.Entities;
using System.Collections.Generic;
using System.Globalization;

namespace DLLFigureAbstractArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of shapes: ");
            int nShapes = int.Parse(Console.ReadLine());
            Console.WriteLine();

            List<Shape> shape = new List<Shape>();

            for(int i=1; i<=nShapes; i++)
            {
                Console.WriteLine($"Shapes #{i} data: ");
                Console.Write("Rectangle or Cicle (r/c)? ");
                Char rectangleOrCicle = Char.Parse(Console.ReadLine());
                Console.Write("Color (Black/Blue/Red): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());

                if(rectangleOrCicle == 'r')
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    shape.Add(new Rectangle(width, height, color));
                }
                else
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    shape.Add(new Circle(radius, color));
                }
            }

            foreach (Shape s in shape) Console.WriteLine(s);

            
        }
    }
}
