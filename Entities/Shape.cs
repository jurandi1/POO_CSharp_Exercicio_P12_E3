using POO_CSharp_Exercicio_P12_E3.Entities.Enums;

namespace POO_CSharp_Exercicio_P12_E3.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }

        public Shape(Color color) 
        {
            Color = color;
        }

        public abstract double Area(); 
    }
}
