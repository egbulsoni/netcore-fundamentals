using System;

namespace AcertouGanhou
{
    class Program
    {
        static void Main(string[] args)
        {
            Jogo jogo = new Jogo();
            while(true)
            {
                jogo.Tentar();
            }
        }
    }
}
