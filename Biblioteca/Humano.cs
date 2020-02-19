using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca
{
    public class Humano : Criatura
    {
        public Humano(int cor, int custo, int numHabilidade, int habilidade, int descricao, int ataque, int defesa) : base(cor, custo, numHabilidade, habilidade, descricao, ataque, defesa)
        {
            NomeCarta = "Humano";
            FinalizarDescricaoCriatura(descricao);
        }

        public void FinalizarDescricaoCriatura(int descricao)
        {
            DescricaoCarta += Environment.NewLine + Environment.NewLine + $"Descrição: {NomeCarta} {DescreverCriatura(descricao)}";
        }
    }
}
