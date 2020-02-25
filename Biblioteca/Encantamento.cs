using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca
{
    public class Encantamento : CartaHabilidade
    {
        public Encantamento(int cor, int custo, int numHabilidade, int habilidade1, int habilidade2) : base(cor, custo)
        {
            TipoCarta = "Encantamento";
            NomeEDescricaoEncantamento(numHabilidade, habilidade1, habilidade2);
        }

        public void NomeEDescricaoEncantamento(int numHabilidade, int habilidade1, int habilidade2)
        {
            if (numHabilidade == 0)
            {
                NomeCarta = "13 Gatos pretos";
                DescricaoCarta = "Esta carta não possui habilidades.";
                AcaoHabilidade = 0;
            }
            else if (numHabilidade == 1)
            {
                NomeCarta = Habilidades[habilidade1].NomeAcao;
                DescricaoCarta = "Habilidade 1: " + Habilidades[habilidade1].DescricaoAcao;
                AcaoHabilidade = Habilidades[habilidade1].AcaoAcao;
            }
            else
            {
                NomeCarta = "Trevo de 4 folhas";

                DescricaoCarta = $"Habilidade 1: " + Habilidades[habilidade1].NomeAcao + ", " + Habilidades[habilidade1].DescricaoAcao + Environment.NewLine;
                AcaoHabilidade = Habilidades[habilidade1].AcaoAcao;

                DescricaoCarta += $"Habilidade 2: " + Habilidades[habilidade2].NomeAcao + ", " + Habilidades[habilidade2].DescricaoAcao;
                AcaoHabilidade += Habilidades[habilidade2].AcaoAcao;
            }
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
