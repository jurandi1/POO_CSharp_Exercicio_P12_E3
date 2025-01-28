using System;
using POO_CSharp_Exercicio_P12_E3.Entities.Enums;

namespace POO_CSharp_Exercicio_P12_E3.Entities
{
    internal class Circle : Shape
    {
        public double Radius { get; set; }

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
