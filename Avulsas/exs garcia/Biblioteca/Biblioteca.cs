using Estante;
using System.Collections.Generic;
using System;
using Livro;

namespace Biblioteca
{
    public class Biblioteca
    {
        public Array<Estante> Estantes { get; set; }    
        public void inserirEstante(Estante estante)
        {
            Estantes.Add(estante);
        }

        public void inserirLivro(Livro livro)
        {
            // Não consigo appendar o livro na estante certa, sabe-se la deus porque.
            // Estantes.ForEach(delegate(Estante estante)
            // {
            //     if(estante.Categoria == livro.Categoria)
            //     {
            //     }
                
            // });

            //NEM TENTANDO APPENDAR POR REFERENCIA ESSA DESGRAÇA NAO VAI
            int index = Estantes.FindIndex(e => e.Categoria == livro.Categoria);
            Estantes[index] = livro;
            // ahhh, é porque eu estava utilizando uma lista ligada ao invés de um array ;)

        }

    }
}