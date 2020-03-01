using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca
{
    public abstract class CartaHabilidade : Carta
    {
        public int AcaoHabilidade { get; set; }

        public CartaHabilidade(int cor, int custo) : base(cor)
        {
            CustoCarta = custo;
        }
    }
}
