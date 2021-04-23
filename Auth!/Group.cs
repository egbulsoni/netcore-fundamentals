using System;
class Group:Usuario
{
    public string GroupName { get; set; }
    
    
    public Group(string nome, string groupName)
    {
        Nickname = nome;
        GroupName = groupName;
        TipoDeUsuario = TipoUser.Group.ToString();
    }
    public string DescricaoPermissao()
    {
        Console.WriteLine($"{Nickname} pode: desmanchar o grupo, convidar alguem para este grupo, remover alguem do grupo");
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