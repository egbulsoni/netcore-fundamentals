using System;
using System.Collections.Generic;


namespace Biblioteca
{
    public class Estante
    {
        public string Nome { get; private set; }
        public Categoria Cat { get; private set; }
        public List<Livro> Livros { get; private set; }

        public List<Livro> listarFilosofia()
        {
            List<Livro> ls = new List<Livro>();
            foreach (Livro l in Livros)
            {
                if(l.Categoria == "Filosofia"){
                    ls.Add(l);
                }
            }
            return ls;
        }
        public int contarCiencia()
        {
            int contador = 0;
            foreach(Livro l in Livros)
            {
                if(l.Categoria == "Ciência")
                {
                    contador++;
                }
            }
            return contador;
        }

        public void listarTudo()
        {
            foreach (Livro l in Livros)
            {
                Console.WriteLine($"Categoria do livro:{l.Categoria}\nNome do livro:{l.Nome}\nNome do autor:{l.Autor}\nAno de publicação:{l.AnoDePublicacao}\n\n");
                
            }
        }
        
        public void removerLivro(Livro livro){
            foreach(Livro l in Livros)
            {
                if(l.Nome == livro.Nome)
                {
                    Livros.Remove(l);
                }
            }
        }

        public List<String> listarAutores(Categoria cat)
        {

        }
        

        // TODO - implementar (6 e 7)
    }
}