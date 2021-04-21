class Premium : Cliente
{
    public Premium(string nome, double saldo) : base(nome, saldo)
    {
    }

    public override double calcularTarifa()
    {
        var tarifa = this.Saldo * 0.02;
        return tarifa;
    }
}