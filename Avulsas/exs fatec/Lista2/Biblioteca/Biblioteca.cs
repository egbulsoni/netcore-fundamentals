using System.Collections.Generic;
using System;

namespace Biblioteca
{
    public class Biblioteca
    {
        public List<Estante> Estantes { get; set; }    
        public void inserirEstante(Estante estante)
        {
            Estantes.Add(estante);
        }

        
    }
}