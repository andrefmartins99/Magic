using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca
{
    public class MagicaInstantanea : CartaEfeito
    {
        public MagicaInstantanea(int cor, int custo, int efeito) : base(cor, custo, efeito)
        {
            TipoCarta = "Mágica Instantânea";
        }
    }
}
