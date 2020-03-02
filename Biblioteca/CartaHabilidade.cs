using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca
{
    public abstract class CartaHabilidade : Carta
    {
        public List<Habilidade> Habilidades { get; }

        public int AcaoHabilidade { get; set; }

        public CartaHabilidade(int cor, int custo, List<Habilidade> habilidades) : base(cor, custo)
        {
            Habilidades = habilidades;
        }
    }
}
