class Vip : Cliente
{
    public Vip(string nome, double saldo) : base(nome, saldo)
    {
    }

    public override double calcularTarifa()
    {
        var tarifa = this.Saldo * 0.04;
        return tarifa;
    }
}