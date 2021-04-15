using System;

public class PessoaJuridica
{
    public override void taxaEmprestimo(double valor)
    {
        Console.WriteLine("Taxa de empréstimo para Pessoa Física R$ " + (valor * 0.2));

    }
}
