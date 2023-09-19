namespace GeometricShapes
{
    public class Triangle : AbstractShape
    {
        public double SideOne { get; set; }
        public double SideTwo { get; set; }
        public double SideThree { get; set; }

        public override string Name => "Треугольник";

        public override double AreaOfTheShape()
        {
            double HalfPerimeter = (SideOne + SideTwo + SideThree) / 2;
            return Math.Sqrt(HalfPerimeter * (HalfPerimeter - SideOne) * (HalfPerimeter - SideTwo) * (HalfPerimeter - SideThree));
        }
        public bool Pifagor()
        {
            var Sides = new[] { SideOne, SideTwo, SideThree };
            double max = -1;
            int maxindex = -1;
            for (int i = 0; i < Sides.Length; i++)
            {
                if (Sides[i] > max)
                {
                    maxindex = i;
                    max = Sides[i];
                }
            }
            double sum = 0;
            for (int i = 0; i < Sides.Length; i++)
            {
                if (i == maxindex)
                {
                    continue;
                }
                else
                {
                    sum += Sides[i] * Sides[i];
                }
            }
            if (Sides[maxindex] * Sides[maxindex] == sum)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
