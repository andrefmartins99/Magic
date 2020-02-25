using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca
{
    public abstract class Criatura : CartaHabilidade
    {
        public int AtaqueCriatura { get; set; }

        public int DefesaCriatura { get; set; }

        public Criatura(int cor, int custo, int numHabilidade, int habilidade1, int habilidade2, int ataque, int defesa) : base(cor, custo)
        {
            TipoCarta = "Criatura";
            DescricaoCriatura(numHabilidade, habilidade1, habilidade2);
            AtaqueCriatura = ataque;
            DefesaCriatura = defesa;
        }

        public void DescricaoCriatura(int numHabilidade, int habilidade1, int habilidade2)
        {
            if (numHabilidade == 0)
            {
                DescricaoCarta = "Esta carta não possui habilidades." + Environment.NewLine;
                AcaoHabilidade = 0;
            }
            else if (numHabilidade == 1)
            {
                DescricaoCarta = "Habilidade 1: " + Habilidades[habilidade1].NomeAcao + ", " + Habilidades[habilidade1].DescricaoAcao + Environment.NewLine;
                AcaoHabilidade = Habilidades[habilidade1].AcaoAcao;
            }
            else
            {
                DescricaoCarta = "Habilidade 1: " + Habilidades[habilidade1].NomeAcao + ", " + Habilidades[habilidade1].DescricaoAcao + Environment.NewLine;
                AcaoHabilidade = Habilidades[habilidade1].AcaoAcao;

                DescricaoCarta += "Habilidade 2: " + Habilidades[habilidade2].NomeAcao + ", " + Habilidades[habilidade2].DescricaoAcao + Environment.NewLine;
                AcaoHabilidade += Habilidades[habilidade2].AcaoAcao;
            }
        }

        public string DescreverCriatura(int descricao)
        {
            string descrever;

            switch (descricao)
            {
                case 0:
                    descrever = "é uma carta matreira, se não tiveres de olho nela ela rouba-te a escova dos dentes";
                    break;

                case 1:
                    descrever = "é uma carta frágil, coitada nasceu com ossos de vidro";
                    break;

                case 2:
                    descrever = "é uma carta habilidosa, consegue fazer malabarismo com 2 bolas desde os 10 anos";
                    break;

                case 3:
                    descrever = "é uma carta preocupada, consigo mesma";
                    break;

                case 4:
                    descrever = "é uma carta empenhada, em não fazer nada da vida";
                    break;

                default:
                    descrever = "é uma carta frágil, coitada nasceu com ossos de vidro";
                    break;
            }

            return descrever;
        }

        public override string ToString()
        {
            return $"{TipoCarta}{Environment.NewLine}" +
                $"{Environment.NewLine}" +
                $"Nome: {NomeCarta}{Environment.NewLine}" +
                $"Cor: {CorCarta}{Environment.NewLine}" +
                $"Custo: {CustoCarta} Mana{Environment.NewLine}" +
                $"{Environment.NewLine}" +
                $"{DescricaoCarta}{Environment.NewLine}" +
                $"{Environment.NewLine}" +
                $"Ataque/Defesa: {AtaqueCriatura}/{DefesaCriatura}";
        }
    }
}
