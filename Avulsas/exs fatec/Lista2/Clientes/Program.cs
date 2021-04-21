using System;

namespace Clientes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o nome do cliente: ");
            string nome = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Qual o saldo que este cliente têm em conta?");
            double saldo = Convert.ToDouble(Console.ReadLine());
            Regular c = new Regular(nome, saldo);

            Console.WriteLine($"O cliente de nome {c.Nome} possui {c.Saldo} na conta, tarifa: {c.calcularTarifa()}");
        }
    }
}
