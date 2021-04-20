using System;

namespace EquacaoSegundoGrau
{
    class Program
    {
        static void Main(string[] args)
        {
            Eq2Grau eq = new Eq2Grau(5,3,4);
            Console.WriteLine($"calculo do delta {eq.calcularDelta()}");
            Console.WriteLine($"Par ordenado ({eq.x1}, {eq.x2})");

        }
    }
}
