using System;

namespace Biblioteca
{
    public class Livro
    {
        public string Nome { get; private set; }
        public string Autor { get; private set; }
        public DateTime AnoDePublicacao { get; private set; }
        public Categoria Categoria { get; private set; }
        Estante e = new Estante();
        public Livro(string nome, string autor, DateTime anoDePublicacao, Categoria categoria)
        {
            this.Nome = nome;
            this.Autor = autor;
            this.AnoDePublicacao = anoDePublicacao;
            this.Categoria = categoria;
        }
        public void inserirLivro(Livro livro)
        {
            e.Livros.Add(livro);   
        }

        

    }

}