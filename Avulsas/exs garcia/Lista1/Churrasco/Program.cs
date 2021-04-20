using System;

namespace Churrasco
{
    class Program
    {
        static void Main(string[] args)
        {
            Churras c = new Churras();
            Pessoa p = new Pessoa(9, "lin", "fem", false);
            
            Pessoa p2 = new Pessoa(13, "Ian", "masc", true);
            
            Pessoa p3 = new Pessoa(15, "Vlad", "masc", false);
            Console.WriteLine($"beef consumption by {p.Nome} " + c.verificarConsumo(p) + "kg");
            Console.WriteLine($"beef consumption by {p2.Nome} " + c.verificarConsumo(p2) + "kg");
            Console.WriteLine($"beef consumption by {p3.Nome} " + c.verificarConsumo(p3) + "kg");
            
        }
    }
}
