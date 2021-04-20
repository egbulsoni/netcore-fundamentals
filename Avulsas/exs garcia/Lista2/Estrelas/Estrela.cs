using System;
public class Estrela
{
    public string Nome { get; set; }
    public int Temperatura { get; set; }
    public string Cor { get; set; }

    // Uma pena não conseguirmos representar Qualia com dados, não é mesmo?
    // será que um enum seria suficiente? anyways
    public Estrela(string nome, int temperatura, string cor)
    {
        Nome = nome;
        Temperatura = temperatura;
        Cor = cor;
    }

    public void mostrar()
    {
        Console.WriteLine($"A estrela de nome {Nome}, temperatura {Temperatura} e cor {Cor} está em evidência neste momento");
    }

}