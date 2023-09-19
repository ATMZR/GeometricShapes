using GeometricShapes;
using System.Reflection.Metadata;

namespace GeometricShapes
{
    public abstract class AbstractShape
    {
        public abstract string Name { get; }
        public abstract double AreaOfTheShape();

        public void CalculateAreaOfTheShape(AbstractShape shape)
        {
            double AreaOfTheShape = shape.AreaOfTheShape();
            Console.WriteLine($"Площадь фигуры {shape.Name}: " + Math.Round(AreaOfTheShape, 2));
        }

    }
}