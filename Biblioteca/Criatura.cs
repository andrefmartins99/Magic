using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca
{
    public abstract class Criatura : CartaHabilidade
    {
        public int AtaqueCriatura { get; set; }

        public int DefesaCriatura { get; set; }

        public Criatura(int cor, int custo, int numHabilidade, int habilidade, int descricao, int ataque, int defesa) : base(cor, custo)
        {
            TipoCarta = "Criatura";
            DescricaoCriatura(numHabilidade, habilidade, descricao);
            AtaqueCriatura = ataque;
            DefesaCriatura = defesa;
        }

        public void DescricaoCriatura(int numHabilidade, int habilidade, int descricao)
        {
            Random rng = new Random();
            int rnd;
            int contador = 1;

            if (numHabilidade == 0)
            {
                DescricaoCarta = "Esta carta não possui habilidades.";
            }
            else if (numHabilidade == 1)
            {
                DescricaoCarta = "Habilidade 1: " + Habilidades[habilidade].NomeAcao + ", " + Habilidades[habilidade].DescricaoAcao;
            }
            else
            {
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

        public string DescreverCriatura(int descricao)
        {
            string descrever;

            switch (descricao)
            {
                case 0:
                    descrever = "é uma carta matreira, se não tiveres de olho nela ela ROUBA-TE a escova dos dentes";
                    break;

                case 1:
                    descrever = "é uma carta frágil, coitada nasceu com ossos de vidro";
                    break;

                case 2:
                    descrever = "é uma carta";
                    break;

                case 3:
                    descrever = "é uma carta";
                    break;

                case 4:
                    descrever = "é uma carta";
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
                $"Custo: {CustoCarta}{Environment.NewLine}" +
                $"{Environment.NewLine}" +
                $"{DescricaoCarta}{Environment.NewLine}" +
                $"{Environment.NewLine}" +
                $"Ataque/Defesa: {AtaqueCriatura}/{DefesaCriatura}";
        }
    }
}
