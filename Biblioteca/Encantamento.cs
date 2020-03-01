using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca
{
    public class Encantamento : CartaHabilidade
    {
        public Encantamento(int cor, int custo, int numHabilidade, int habilidade1, int habilidade2, List<Habilidade> Habilidades) : base(cor, custo)
        {
            TipoCarta = "Encantamento";
            NomeCarta = MetodosEncantamento.NomeEncantamento(numHabilidade, habilidade1, Habilidades);
            DescricaoCarta = MetodosEncantamento.DescricaoEncantamento(numHabilidade, habilidade1, habilidade2, Habilidades);
            AcaoHabilidade = MetodosEncantamento.AcaoEncantamento(numHabilidade, habilidade1, habilidade2, Habilidades);
        }

        public override string ToString()
        {
            return $"{TipoCarta}{Environment.NewLine}" +
                $"{Environment.NewLine}" +
                $"Nome: {NomeCarta}{Environment.NewLine}" +
                $"Cor: {CorCarta}{Environment.NewLine}" +
                $"Custo: {CustoCarta} Mana{Environment.NewLine}" +
                $"{Environment.NewLine}" +
                $"{DescricaoCarta}";
        }
    }
}
