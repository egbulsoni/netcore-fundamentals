public class Porta
{
    public bool isOpen { get; set; }
    public static int numAberturas { get; set; } = 0;
    public Porta()
    {
        this.isOpen = false;
    }

    public void abrir()
    {
        this.isOpen = !isOpen;
        acrescentarQtdAberturas();
    }
    public static void acrescentarQtdAberturas()
    {
        numAberturas++;
    }
    public void fechar()
    {
        if (this.isOpen)
        {
            this.isOpen = !this.isOpen;
        }
    }

}