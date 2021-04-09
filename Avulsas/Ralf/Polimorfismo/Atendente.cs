using System;

namespace _11Polimorfismo
{
    class Atendente : Imposto
    {
        public override void valeAlimentacao(double salario)
        {
            Console.WriteLine("Desconto gerente do vale alimentação R$" +(salario * 0.12));
        }
    }

}