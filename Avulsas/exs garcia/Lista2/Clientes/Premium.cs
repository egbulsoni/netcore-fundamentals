class Premium : Cliente
{
    public calcularTarifa()
    {
        var tarifa = this.Saldo * 0.02;
        return tarifa;
    }
}