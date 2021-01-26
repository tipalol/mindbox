using System;
namespace GeometryDash.Figures
{
    public class Circle : IFigure
    {
        public double Radius { get; private set; }

        public Circle(int radius)
        {
            if (radius < 0)
                throw new ArgumentException("Radius must be positive value or 0");

            Radius = radius;
        }

        public double CalculateSquare()
            => Math.PI * Math.Pow(Radius, 2);
    }
}
