using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca
{
    public class Feitico : CartaEfeito
    {
        public Feitico(int cor, int custo, int efeito, List<Efeito> Efeitos) : base(cor, custo, efeito, Efeitos)
        {
            TipoCarta = "Feitiço";
        }
    }
}
