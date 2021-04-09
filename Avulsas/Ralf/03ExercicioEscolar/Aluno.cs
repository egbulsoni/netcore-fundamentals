using System;

namespace _03ExercicioEscolar
{
    public class Aluno
    {
       // Atributos
       public string nome;
       public double nota1, nota2;

       // Média
        public double media()
        {
            var result = (nota1+nota2) /2;
            return result;
        }
       // Situação

        public string situacao(double media)
        {
            return media >= 7 ? "aprovado" : "reprovado";
        }

       // Mensagem
       public void mensagem()
       {
           // Obter a media
           double obterMedia = media();

           // Obter situação
           string obterSituacao = situacao(obterMedia);

           // Mensagem
           Console.WriteLine($"{nome} está {obterSituacao} com média {obterMedia}");
       }
    }
}