using Abstract.Entities;
using Abstract.Entities.Enums;

namespace Abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Shape> list = new List<Shape>();
            
            Console.Write("Enter the number of shapes: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++) 
            {
                Console.WriteLine($"Shape #{i} data: ");
                Console.WriteLine("Rectangle or circle? (r/c)");
                char ch = char.Parse(Console.ReadLine());
                Console.WriteLine("Color: (Black/Blue/Red) ");
                Color color = Enum.Parse<Color>(Console.ReadLine());

                if(ch =='r' || ch == 'R')
                {
                    Console.WriteLine("Width: ");
                    double width = double.Parse(Console.ReadLine());
                    Console.WriteLine("Height: ");
                    double height = double.Parse(Console.ReadLine());

                    list.Add(new Rectangle(color, height,width));
                }
                else
                {
                    Console.WriteLine("Radius: ");
                    double radius = double.Parse(Console.ReadLine());
                    list.Add(new Circle(radius, color));

                }
                
            }
            Console.WriteLine();
            Console.WriteLine("Shape areas: ");
            foreach (Shape shape in list)
            {
                Console.WriteLine(shape.Area().ToString());
            }

        }
    }
}