using System;
class Guest:Usuario
{
    public override string DescricaoPermissao()
    {
        Console.WriteLine("Você pode usar o sistema para coisas simples, nada de salvar ou baixar arquivos");
    }
    public string MsgBoasVindas()
    {
        Console.WriteLine($"Você é o usuário {Nickname}, com permissões de GRUPO");
    }

    public void DespedidaGroup()
    {
        Console.WriteLine($"Usuário {Nickname} está se desvencilhando do grupo, passando a liderança para outro membro.");
    }

}