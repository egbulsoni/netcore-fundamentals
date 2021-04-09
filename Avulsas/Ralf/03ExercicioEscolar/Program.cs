using System;

namespace _03ExercicioEscolar
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            Aluno a = new Aluno();
            a.nome = "Dênis";
            a.nota1 = 8;
            a.nota2 = 3;
            a.mensagem();
        }
    }
}
