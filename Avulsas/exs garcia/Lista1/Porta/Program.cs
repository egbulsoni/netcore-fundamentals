using System;

class Program
{
    static void Main(string[] args)
    {
        Porta p = new Porta();
        Porta p2 = new Porta();
        Porta p3 = new Porta();
        p.abrir();
        p2.abrir();
        p.fechar();
        p3.abrir();
        p3.fechar();
        p3.abrir();

        Console.WriteLine(Porta.numAberturas);
    }
}
