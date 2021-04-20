using System;

namespace AcertouGanhou
{
    public class Jogo
    {
        public int NumeroGerado { get; set; }
        public int LimiteDeCima { get; set; }
        public int LimiteDeBaixo { get; set; }
        public Jogo()
        {
            Random rnd = new Random();
            NumeroGerado = rnd.Next(0,99);
            LimiteDeCima = 99;
            LimiteDeBaixo = 0;
        }
        public void Tentar()
        {
            Console.WriteLine("Digite um numero");
            var tentativa = int.Parse(Console.ReadLine());
            if(tentativa == NumeroGerado)
            {
                Console.WriteLine("você ganhou!");
                return;
            }
            else if(tentativa > NumeroGerado)
            {
                LimiteDeCima = tentativa;
                Console.WriteLine($"O limite está entre {LimiteDeBaixo} .. {LimiteDeCima}");
            }
            else if(tentativa < NumeroGerado)
            {
                LimiteDeBaixo = tentativa;
                Console.WriteLine($"O limite está entre {LimiteDeBaixo} .. {LimiteDeCima}");
            }
            else if(tentativa == 0)
            {
                return;
            }

        }
        
    }
}