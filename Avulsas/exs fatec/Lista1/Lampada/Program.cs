using System;

namespace Lampada
{
    class Program
    {
        static void Main(string[] args)
        {
            Lampada lamp = new Lampada(20);
            Console.WriteLine($"A quantidade disponível de cliques é: {lamp.verificarDurabilidade()}");
            lamp.toggle();
            Console.WriteLine($"A quantidade disponível de cliques é: {lamp.verificarDurabilidade()}");
            Console.WriteLine(lamp.descricaoAtual());
            
        }
    }
}
