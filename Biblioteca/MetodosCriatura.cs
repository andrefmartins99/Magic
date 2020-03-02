using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca
{
    public static class MetodosCriatura
    {
        /// <summary>
        /// Gerar a descrição de uma criatura (habilidades + flavour text)
        /// </summary>
        /// <param name="numHabilidade">Número gerado por um random, corresponde ao número de habilidades que a criatura tem</param>
        /// <param name="habilidade1">Número gerado por um random, corresponde à 1º habilidade da criatura</param>
        /// <param name="habilidade2">Número gerado por um random, corresponde à 2º habilidade da criatura</param>
        /// <param name="Habilidades">Lista Habilidades</param>
        /// <param name="descricao">Número gerado por um random, corresponde ao flavour text da criatura</param>
        /// <param name="nome">Nome da criatura</param>
        /// <returns>Retorna a descrição da criatura</returns>
        public static string DescricaoCriatura(int numHabilidade, int habilidade1, int habilidade2, List<Habilidade> Habilidades, int descricao, string nome)
        {
            string descrever;

            //Habilidades
            descrever = DescreverHabilidadesCriatura(numHabilidade, habilidade1, habilidade2, Habilidades);
            //Flavour text
            descrever += DescreverCriatura(descricao, nome);

            return descrever;
        }

        /// <summary>
        /// Gerar a descrição das habilidades dependendo do número de habilidades da criatura
        /// </summary>
        /// <param name="numHabilidade">Número gerado por um random, corresponde ao número de habilidades que a criatura tem</param>
        /// <param name="habilidade1">Número gerado por um random, corresponde à 1º habilidade da criatura</param>
        /// <param name="habilidade2">Número gerado por um random, corresponde à 2º habilidade da criatura</param>
        /// <param name="Habilidades">Lista Habilidades</param>
        /// <returns>Retorna a descrição das habilidades</returns>
        public static string DescreverHabilidadesCriatura(int numHabilidade, int habilidade1, int habilidade2, List<Habilidade> Habilidades)
        {
            string descrever;

            if (numHabilidade == 0)
            {
                descrever = "Esta carta não possui habilidades." + Environment.NewLine + Environment.NewLine;
            }
            else if (numHabilidade == 1)
            {
                descrever = "Habilidade 1: " + Habilidades[habilidade1].NomeAcao + ", " + Habilidades[habilidade1].DescricaoAcao + Environment.NewLine + Environment.NewLine;
            }
            else
            {
                descrever = "Habilidade 1: " + Habilidades[habilidade1].NomeAcao + ", " + Habilidades[habilidade1].DescricaoAcao + Environment.NewLine;

                descrever += "Habilidade 2: " + Habilidades[habilidade2].NomeAcao + ", " + Habilidades[habilidade2].DescricaoAcao + Environment.NewLine + Environment.NewLine;
            }

            return descrever;
        }

        /// <summary>
        /// Gerar flavour text da criatura
        /// </summary>
        /// <param name="descricao">Número gerado por um random, corresponde ao flavour text da criatura</param>
        /// <param name="nome">Nome da criatura</param>
        /// <returns>Retorna o flavour text da criatura</returns>
        public static string DescreverCriatura(int descricao, string nome)
        {
            string descrever;

            switch (descricao)
            {
                case 0:
                    descrever = $"Descrição: {nome} é uma carta matreira, se não tiveres de olho nela ela rouba-te a escova dos dentes";
                    break;

                case 1:
                    descrever = $"Descrição: {nome} é uma carta frágil, coitada nasceu com ossos de vidro";
                    break;

                case 2:
                    descrever = $"Descrição: {nome} é uma carta habilidosa, consegue fazer malabarismo com 2 bolas desde os 10 anos";
                    break;

                case 3:
                    descrever = $"Descrição: {nome} é uma carta preocupada, consigo mesma";
                    break;

                case 4:
                    descrever = $"Descrição: {nome} é uma carta empenhada, em não fazer nada da vida";
                    break;

                default:
                    descrever = $"Descrição: {nome} é uma carta frágil, coitada nasceu com ossos de vidro";
                    break;
            }

            return descrever;
        }

        /// <summary>
        /// Gerar o dano a infligir ao adversário a partir das habilidades da criatura
        /// </summary>
        /// <param name="numHabilidade">Número gerado por um random, corresponde ao número de habilidades que a criatura tem</param>
        /// <param name="habilidade1">Número gerado por um random, corresponde à 1º habilidade da criatura</param>
        /// <param name="habilidade2">Número gerado por um random, corresponde à 2º habilidade da criatura</param>
        /// <param name="Habilidades">Lista Habilidades</param>
        /// <returns>Retorna o dano que a criatura irá infligir ao adversário</returns>
        public static int AcaoCriatura(int numHabilidade, int habilidade1, int habilidade2, List<Habilidade> Habilidades)
        {
            int acao;

            if (numHabilidade == 0)
            {
                acao = 0;
            }
            else if (numHabilidade == 1)
            {
                acao = Habilidades[habilidade1].AcaoAcao;
            }
            else
            {
                acao = Habilidades[habilidade1].AcaoAcao;

                acao += Habilidades[habilidade2].AcaoAcao;
            }

            return acao;
        }
    }
}
