namespace Churrasco
{
    public class Pessoa
    {
        public Pessoa(uint idadePessoa,
        string nomePessoa, 
        string sexoPessoa, 
        bool vegetarianoPessoa)
        {
            Idade = idadePessoa;
            Nome = nomePessoa;
            Sexo = sexoPessoa;
            Vegetariano = vegetarianoPessoa;

        }

        public string Nome;
        public string Sexo;
        public uint Idade;
        public bool Vegetariano;

    }
}