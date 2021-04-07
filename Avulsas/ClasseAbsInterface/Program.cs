using System;

namespace ClasseAbsInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // var pagamento = new Pagamento();
            // var pagamentoViaCc = new PagamentoViaCartao();
            var pgto = new PagamentoViaCartao();

        }
    }

    // public interface IPagamento{
    //     // void MinhaFuncao(string qualquerCoisa);
    //     DateTime Vencimento {get; set;}
    //     decimal Valor {get; set;}
    //     void Pagar(decimal valor);
    // }

    public abstract class Pagamento
    {
        public DateTime Vencimento { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public decimal Valor { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public virtual void Pagar(decimal valor)
        {
            Console.WriteLine("Pgto base");            
        }
    }

    public class PagamentoViaCartao : Pagamento
    {
        public override void Pagar(decimal valor)
        {
            base.Pagar(250);
        }
    }

    public class PagamentoViaBoleto
    {
        public void Pagar(decimal valor)
        {
        }
    }
}
