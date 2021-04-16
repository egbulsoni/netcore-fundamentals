using System;

namespace Biblioteca
{
    public class Estante
    {
        public string Nome { get; private set; }
        public string Categoria { get; private set; }
        public Array<Livro> Livros { get; private set; }
        
    }
}