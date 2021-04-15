using System;

namespace _09This
{
    public class Pessoa
    {
        // Atributo
        private string nome = "Tatiana";
        public Pessoa(string nome)
        {
            Console.WriteLine(nome);
            Console.WriteLine(this.nome);
        }
    }
}