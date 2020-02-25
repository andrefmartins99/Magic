using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca
{
    public class Anao : Criatura
    {
        public Anao(int cor, int custo, int numHabilidade, int habilidade1, int habilidade2, int descricao, int ataque, int defesa) : base(cor, custo, numHabilidade, habilidade1, habilidade2, ataque, defesa)
        {
            NomeCarta = "Anão";
            FinalizarDescricaoCriatura(descricao);
        }

        public void FinalizarDescricaoCriatura(int descricao)
        {
            DescricaoCarta += Environment.NewLine + $"Descrição: {NomeCarta} {DescreverCriatura(descricao)}";
        }
    }
}
