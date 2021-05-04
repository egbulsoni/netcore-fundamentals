using System;

namespace Auth
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Root rute = new Root("Dona Rute");
            Regular regular = new Regular("João das couves");
            Guest kenshin = new Guest();
            rute.MsgBoasVindas();
            regular.MsgBoasVindas();
            kenshin.MsgBoasVindas();
            

        }
    }
}
