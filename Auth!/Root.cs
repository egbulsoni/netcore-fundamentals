using System;
class Root:Usuario
{
    public Root(string nome)
    {
        Nickname = nome;
        TipoDeUsuario = TipoUser.Root.ToString();
    }
    public void excluirTodos()
    {
        // admin tocando o terror dando delete sem where
        Console.WriteLine("Deletando todos os usuários...");
        // maldade isso aí, pode ver que o retorno disso é nulo!
    }
    public override string DescricaoPermissao()
    {
        Console.WriteLine($"Você tem a autoridade completa e irrestrita diante deste sistema.");
        // return $"Bem vindo {Nickname}, você é vital para o bom funcionamento do sistema!";
        return "Faz até chover canivete, já diria minha professora Bem Aventurada.";
    }

    public void DespedidaRoot()
    {
        Console.WriteLine($"Usuario {Nickname}, que possui as permissões de {TipoDeUsuario} Deslogando do sistema");
    }

}