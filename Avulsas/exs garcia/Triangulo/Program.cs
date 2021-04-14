using System;

namespace Triangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Equilatero eq = new Equilatero(5);
            Console.WriteLine($"triangulo equilatero com area {eq.calcArea()} e perimetro {eq.calcPerimetro()}");
        }
    }
}
