class  EquipamentoSonoro: Equipamento, IEquipamentoSonoro
{
    public bool Stereo { get; private set; }
    public int Volume { get; private set; }    
    public EquipamentoSonoro(bool ligado) : base(ligado)
    {
        Ligado = ligado;
    }
    public void aumentarVolume()
    {
        if(Volume < 100)
        {
            Volume += 5;
        }
    }

    public void diminuirVolume()
    {
        if(Volume >0)
        {
            Volume -= 5;
        }
    }

    public new void ligar()
    {
        base.ligar();
        Volume += 5;
    }

    public void mono()
    {
        Stereo = false;
    }
    public void stereo()
    {
        Stereo = true;
    }

    public new string toString()
    {
        var stereoOn = Stereo == true ? "ligado" : "desligado";
        var result = string.Join(base.toString(), $"O stereo está: {stereoOn} e o volume está em: {Volume}");
        return result;
    }
}