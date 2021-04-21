using System;
using System.Collections.Generic;

public class Constelacao{
    public string NomeConstelação { get; set; }
    public List<Estrela> Estrelas { get; set; }
    
    public Constelacao(string nome, List<Estrela> estrelas)
    {
        NomeConstelação = nome;
        Estrelas = estrelas;
    }
    public void adicionar(Estrela e)
    {
        Estrelas.Add(e);
    }

    public void infoEstrelas()
    {
        foreach(Estrela e in Estrelas)
        {
            e.mostrar();
        }
    }

    public double tempConstelacao()
    {
        double total = 0;
        foreach(Estrela e in Estrelas)
        {
            total += e.Temperatura;
        }
        return total;
    }
    
    
}