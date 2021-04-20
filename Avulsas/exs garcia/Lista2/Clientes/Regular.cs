class Regular : Cliente
{
    public Regular(string nome, double saldo) : base(nome, saldo)
    {
    }

    public override double calcularTarifa()
    {
        var tarifa = this.Saldo * 0.01;
        return tarifa;
    }
}