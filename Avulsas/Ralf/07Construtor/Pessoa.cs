using System;

namespace _07Construtor
{
    public class Pessoa
    {
        public Pessoa()
        {
            Console.WriteLine("Construtor executado");
        }
        public Pessoa(string nome)
        {
            Console.WriteLine("Olá " + nome);
        }

    }

}