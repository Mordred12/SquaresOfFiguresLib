using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquaresOfFiguresLib
{
    public abstract class CalcFigures
    {
      
        public abstract double CalcSquare();
    }
    public class SquareCircle : CalcFigures
    {
        public double radius;

        public SquareCircle(double radius)
        {
            this.radius = radius;
        }
        public override double CalcSquare()
        {
            return Math.Round(Math.PI * radius * radius, 1);
        }
    }
    public class SquareTriangle : CalcFigures
    {
        public double a;
        public double b;
        public double c;
        public SquareTriangle(double a, double b, double c)
        {
            if (a < 0 || b < 0 || c < 0) throw new ArgumentException($"Несуществующий треугольник");
            else if (a > (b + c) || b > (a + c) || c > (a + b)) throw new ArgumentException($"Несуществующий треугольник");
            else
            {
                this.a = a;
                this.b = b;
                this.c = c;
            }
        }
        public override double CalcSquare()
        {
            double p = (a + b + c) / 2;
 
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
        public bool Rectangular()
        {
            bool rectangular = (a * a + b * b == c * c) || (a * a + c * c == b * b) || (c * c + b * b == a * a);
            return rectangular;
        }
    }
}
