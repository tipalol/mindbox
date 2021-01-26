using System;
namespace GeometryDash.Figures
{
    public class Triangle : IFigure
    {
        public double A { get; private set; }
        public double B { get; private set; }
        public double C { get; private set; }

        public double Perimeter => A + B + C;
        public bool IsRight => Math.Pow(C, 2) == Math.Pow(A, 2) + Math.Pow(B, 2);

        private double p => Perimeter / 2;

        public Triangle(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
                throw new ArgumentException("Values must be positive");

            A = a;
            B = b;
            C = c;
        }

        public double CalculateSquare()
            => IsRight ? CalculateSquareRight() : CalculateSquareGeron();

        private double CalculateSquareGeron()
            => Math.Sqrt(p * (p - A) * (p - B) * (p - C));

        private double CalculateSquareRight()
            => (A * B) / 2d;
    }
}
