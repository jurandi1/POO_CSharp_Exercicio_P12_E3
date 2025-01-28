using POO_CSharp_Exercicio_P12_E3.Entities.Enums;

namespace POO_CSharp_Exercicio_P12_E3.Entities
{
    internal class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height, Color color) : base(color)
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
