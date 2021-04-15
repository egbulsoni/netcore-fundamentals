using System;
namespace _06Encapsulamento
{
    public class Aluno
    {
        //Atributos
        private double nota1, nota2;

        // Media

        private double media()
        {
            return (nota1+nota2)/2;
        }
        
        public void mensagem()
        {
            Console.WriteLine("Informe a primeira nota");
            nota1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe a segunda nota");
            nota2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"A média é {media()}");
        }
    }
}