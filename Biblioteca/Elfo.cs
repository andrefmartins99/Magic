using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca
{
    public class Elfo : Criatura
    {
        public Elfo(int cor, int custo, int numHabilidade, int habilidade1, int habilidade2, int descricao, int ataque, int defesa, List<Habilidade> Habilidades) : base(cor, custo, numHabilidade, habilidade1, habilidade2, ataque, defesa, Habilidades)
        {
            NomeCarta = "Elfo";
            DescricaoCarta = MetodosCriatura.DescricaoCriatura(numHabilidade, habilidade1, habilidade2, Habilidades, descricao, NomeCarta);
        }
    }
}
