using System;

namespace _11Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // Estagiario
            Imposto objetoE = new Estagiario();
            objetoE.valeAlimentacao(1000);
            objetoE.valeTransporte(1000);
            Console.WriteLine("-----------");
            // Atendente
            Imposto objetoA = new Atendente();
            objetoA.valeAlimentacao(2000);
            objetoA.valeTransporte(2000);
            Console.WriteLine("-----------");
            // Gerente
            Imposto objetoG = new Gerente();
            objetoG.valeAlimentacao(5000);
            objetoG.valeTransporte(5000);
        }
    }
}
