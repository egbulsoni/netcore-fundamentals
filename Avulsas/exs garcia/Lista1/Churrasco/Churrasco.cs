using Churrasco;

namespace Churrasco
{
    public class Churras
    {
        public double qtdCarne;
        public int? verificarConsumo(Pessoa p)
        {
            if(p.Idade < 4 || p.Vegetariano)
            {
                return null; 
            } 
            else if(p.Idade >= 4 && p.Idade <= 12)
            {
                return 1;
            } 
            else if(p.Idade < 0)
            {
                return null;
            }
            else
            {
                return 2;
            }
        }
    }
}