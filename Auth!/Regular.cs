using System;
class Regular:Usuario
{    
    public Regular(string nome)
    {
        Nickname = nome;
        TipoDeUsuario = TipoUser.Regular.ToString();
    }
    public void Dashboard()
    {
        Console.WriteLine("Bem vindo ao dashboard");
    }
    public override string DescricaoPermissao()
    {
        Console.WriteLine($"Você pode: excluir seus personagens e controlar os mesmos");
        return $"Bem vindo ao mundo {Nickname}, você é um personagem único/autêntico!";
    }

    public void DespedidaRegular()
    {
        Console.WriteLine($"Usuario {Nickname}, Permissao {TipoDeUsuario} Deslogando do sistema");
    }

    

}