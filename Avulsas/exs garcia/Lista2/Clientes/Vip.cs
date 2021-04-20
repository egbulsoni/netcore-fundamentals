class Vip : Cliente
{
    public calcularTarifa()
    {
        var tarifa = this.Saldo * 0.04;
        return tarifa;
    }
}