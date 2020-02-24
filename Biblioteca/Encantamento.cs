using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca
{
    public class Encantamento : CartaHabilidade
    {
        public Encantamento(int cor, int custo, int numHabilidade, int habilidade) : base(cor, custo)
        {
            TipoCarta = "Encantamento";
            NomeEDescricaoEncantamento(numHabilidade, habilidade);
        }

        public void NomeEDescricaoEncantamento(int numHabilidade, int habilidade)
        {
            Random rng = new Random();
            int rnd;
            int contador = 1;

            if (numHabilidade == 0)
            {
                NomeCarta = "13 Gatos pretos";
                DescricaoCarta = "Esta carta não possui habilidades.";
            }
            else if (numHabilidade == 1)
            {
                NomeCarta = Habilidades[habilidade].NomeAcao;
                DescricaoCarta = "Habilidade 1: " + Habilidades[habilidade].DescricaoAcao;
            }
            else
            {
                NomeCarta = "Trevo de 4 folhas";

                for (int i = 0; i < numHabilidade; i++)
                {
                    if (i == 0)
                    {
                        DescricaoCarta = $"Habilidade 1: " + Habilidades[habilidade].NomeAcao + ", " + Habilidades[habilidade].DescricaoAcao + Environment.NewLine;
                    }
                    else
                    {
                        do
                        {
                            rnd = rng.Next(0, 5);

                        } while (rnd == habilidade);

                        DescricaoCarta += $"Habilidade {contador}: " + Habilidades[rnd].NomeAcao + ", " + Habilidades[rnd].DescricaoAcao + Environment.NewLine;
                    }

                    contador++;
                }
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
