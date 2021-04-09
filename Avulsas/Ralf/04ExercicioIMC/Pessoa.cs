using System;

namespace _04ExercicioIMC
{
    public class Pessoa
    {
        public double peso, altura;
        public double retornaImc()
        {
            return this.peso / (Math.Pow(altura, 2));
        }

        public string statusImc(double peso, double altura)
        {
            var imcPessoa = peso / Math.Pow(altura, 2);
            if (imcPessoa < 18.5)
            {
                return "Abaixo do peso";
            } else if (imcPessoa < 25)
            {
                return "Peso normal";
            } else if (imcPessoa < 30)
            {
                return "Acima do peso";
            } else if (imcPessoa < 35)
            {
                return "Obesidade I";
            }
            else if (imcPessoa < 40)
            {
                return "Obesidade II";
            }
            else if (imcPessoa >= 40)
            {
                return "Obesidade III";
            }

            return "Impesável!";
        }

        public string msgImc()
        {
            return $"seu IMC é {Math.Round(retornaImc(), 2)} e {statusImc(this.peso, this.altura)}";
        }
         
    }
}