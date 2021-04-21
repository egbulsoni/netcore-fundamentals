namespace Triangulo
{
    public class Equilatero
    {
        public double Lado { get; private set; }
        public double Perimetro { get; private set; }
        public double Area { get; private set; }

        public Equilatero(double lado)
        {
            Lado = lado;
        }
        public double calcArea()
        {
            return this.Lado * (this.Lado/2);
        }

        public double calcPerimetro()
        {
            return this.Lado * 3;
        }

    }
}