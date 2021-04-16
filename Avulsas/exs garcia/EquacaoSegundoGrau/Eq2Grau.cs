using System;

namespace EquacaoSegundoGrau
{
    public class Eq2Grau
    {
        // -b +-raiz(b^2-4*a*c)/2*a
        public double a { get; set; }
        public double b { get; set; }
        public double c { get; set; }
        public double x1 { get; set; }
        public double x2 { get; set; }
        public double delta { get; set; }
        
        
        public Eq2Grau(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public double calcularDelta()
        {
            delta = Math.Sqrt(Math.Pow(b, 2) - 4 * a * c);
            x1 = (-b + delta) / 2*a;
            x2 = (-b - delta) / 2*a;
            return delta;
        }
    }
}