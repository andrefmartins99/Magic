using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca
{
    public class Terreno : Carta
    {
        public Terreno(int nome, int cor, int desc, int custo) : base(cor, custo)
        {
            TipoCarta = "Terreno";
            NomeCarta = MetodosTerreno.NomeDaCarta(nome);
            DescricaoCarta = MetodosTerreno.DescricaoDaCarta(nome, desc);
        }
    }
}
