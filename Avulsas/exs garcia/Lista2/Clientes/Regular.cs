class Regular : Cliente
{
    public calcularTarifa()
    {
        var tarifa = this.Saldo * 0.01;
        return tarifa;
    }
}