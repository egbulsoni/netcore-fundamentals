using System;

namespace _04ExercicioIMC
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            Pessoa p = new Pessoa();
            p.peso = 65;
            p.altura = 1.70;
            Console.WriteLine(p.msgImc());       
            
        }
    }
}
