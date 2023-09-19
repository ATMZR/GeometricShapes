namespace GeometricShapes
{
    public class Circle : AbstractShape
    {
        public double Radius { get; set; }

        public override string Name => "Круг";

        public override double AreaOfTheShape()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
