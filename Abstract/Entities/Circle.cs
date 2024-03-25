using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstract.Entities.Enums;

namespace Abstract.Entities
{
    internal class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle() { }

        public Circle(double radius, Color color) : base(color)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
