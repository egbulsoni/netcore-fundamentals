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
    }
    public string DescricaoPermissao()
    {
        Console.WriteLine($"Você tem a autoridade completa e irrestrita diante deste sistema.");
    }

    public void DespedidaRoot()
    {
        Console.WriteLine($"Usuario {Nickname}, que possui as permissões de {TipoDeUsuario} Deslogando do sistema");
    }

}