public abstract class Usuario
{
    public string Nickname { get; set; }
    public string TipoDeUsuario { get; set; }
    public abstract string DescricaoPermissao();
    public string MsgBoasVindas()
    {
        return $"Boas vindas: {Nickname} de nominação {TipoDeUsuario}";
    }
    public abstract void DespedidaUsuario();
    
}