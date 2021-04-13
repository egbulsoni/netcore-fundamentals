namespace Lampada
{
    public class Lampada
    {
        // public bool IsLigada;
        // public uint QtdToggle;
        public bool IsLigada { get; set; }        
        public uint QtdToggle { get; set; }
        

        public Lampada(uint qtdToggle, bool ligada = false)
        {
            this.QtdToggle = qtdToggle;
            this.IsLigada = ligada;
        }
        public uint verificarDurabilidade()
        {
            return this.QtdToggle;
        }
        public void toggle()
        {
            IsLigada = !IsLigada;
            QtdToggle--;
        }
        
        public string descricaoAtual()
        {
            var estadoDaLampada = this.IsLigada ? "Ligada" : "Desligada";
            return $"A lâmpada está {estadoDaLampada}\nVocê pode apertar o interruptor {this.QtdToggle} vezes";
        }
    }
}