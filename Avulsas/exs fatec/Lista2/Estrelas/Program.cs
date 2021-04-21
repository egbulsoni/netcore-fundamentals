using System.Linq;
using System;
using System.Collections.Generic;


public class Program
{
    static void Main(string[] args)
    {
        Estrela x = new Estrela("Seiya", 20000, "prata");
        Estrela y = new Estrela("Shun", 5000, "dourada");
        Estrela z = new Estrela("Goku", 8200, "azul de saiya jeans");
        List<Estrela> lista = new List<Estrela>(){x,y,z};
        Constelacao c = new Constelacao("Orion", lista);
        Console.WriteLine($"temperatura de {c.NomeConstelação}: {c.tempConstelacao()}");

    }
}
