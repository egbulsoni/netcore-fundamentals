class Equipamento : IEquipamento
{
    public bool Ligado { get; set; }
    
    
    public Equipamento(bool ligado)
    {
        Ligado = ligado;
    }    
    public void ligar()
    {
        Ligado = true;
    }
    public void desligar()
    {
        Ligado = false;
    }

    public string toString()
    {
        var isOn = Ligado == true ? "ligado" : "desligado";
        return $"O equipamento está {isOn}";
    }

}