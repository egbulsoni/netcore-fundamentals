using System;

namespace Biblioteca
{
    public class Livro
    {
        public string Nome { get; private set; }
        public string Autor { get; private set; }
        public DateTime AnoDePublicacao { get; private set; }
        public string Categoria { get; private set; }
        
        public Livro(string nome, string autor, DateTime anoDePublicacao, string categoria)
        {
            this.Nome = nome;
            this.Autor = autor;
            this.AnoDePublicacao = anoDePublicacao;
            this.Categoria = categoria;
        }
        public void inserirLivro(Livro livro)
        {
            Estante e = new Estante();
            
        }

        

    }

}