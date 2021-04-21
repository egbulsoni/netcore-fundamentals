using System;

namespace OOP_lista2
{
    class Program
    {
        static void Main(string[] args)
        {
            EquipamentoSonoro e = new EquipamentoSonoro(true);
            e.aumentarVolume();
            e.aumentarVolume();
            e.aumentarVolume();
            Console.WriteLine(e.toString());
            
            e.stereo();
            e.diminuirVolume();
            Console.WriteLine(e.toString());
            
        }
    }
}
