using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstract.Entities.Enums;

namespace Abstract.Entities
{
    internal class Rectangle : Shape
    {

        public double Height { get; set; }
        public double Width { get; set; }
        
        public Rectangle(Color color,double width, double height) : base(color)
        {
            Width = width;
            Height = height;
        }
        
        public override double Area()
        {
            return Width * Height;
        }
    }
}
