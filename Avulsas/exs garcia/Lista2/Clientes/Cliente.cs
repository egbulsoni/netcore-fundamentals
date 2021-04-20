public abstract class Cliente
{
    public string Nome { get; set; }
    public double Saldo { get; set; }
    public Cliente(string nome, double saldo)
    {
        this.Nome = nome;
        this.Saldo = saldo;
    }
    public abstract double calcularTarifa();
    
    
    
}