using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca
{
    public class MagicaInstantanea : CartaEfeito
    {
        public MagicaInstantanea(int cor, int custo, int efeito, List<Efeito> Efeitos) : base(cor, custo, efeito, Efeitos)
        {
            TipoCarta = "Mágica Instantânea";
        }
    }
}
