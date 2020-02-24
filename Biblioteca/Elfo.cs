using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca
{
    public class Elfo : Criatura
    {
        public Elfo(int cor, int custo, int numHabilidade, int habilidade, int descricao, int ataque, int defesa) : base(cor, custo, numHabilidade, habilidade, descricao, ataque, defesa)
        {
            NomeCarta = "Elfo";
            FinalizarDescricaoCriatura(descricao);
        }

        public void FinalizarDescricaoCriatura(int descricao)
        {
            DescricaoCarta += Environment.NewLine + $"Descrição: {NomeCarta} {DescreverCriatura(descricao)}";
        }
    }
}
