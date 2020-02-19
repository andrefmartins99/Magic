using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca
{
    public class Feitico : CartaEfeito
    {
        public Feitico(int cor, int custo, int efeito) : base(cor, custo, efeito)
        {
            TipoCarta = "Feitiço";
        }
    }
}
