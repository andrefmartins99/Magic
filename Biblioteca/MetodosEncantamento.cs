using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca
{
    public static class MetodosEncantamento
    {
        /// <summary>
        /// Gerar o nome da carta dependendo do número de habilidades que o encantamento tem
        /// </summary>
        /// <param name="numHabilidade">Número gerado por um random, corresponde ao número de habilidades que o encantamento tem</param>
        /// <param name="habilidade1">Número gerado por um random, corresponde à 1º habilidade do encantamento</param>
        /// <param name="Habilidades">Lista Habilidades</param>
        /// <returns>Retorna o nome da carta</returns>
        public static string NomeEncantamento(int numHabilidade, int habilidade1, List<Habilidade> Habilidades)
        {
            string nome;

            if (numHabilidade == 0)
            {
                nome = "13 Gatos pretos";
            }
            else if (numHabilidade == 1)
            {
                nome = Habilidades[habilidade1].NomeAcao;
            }
            else
            {
                nome = "Trevo de 4 folhas";
            }

            return nome;
        }

        /// <summary>
        /// Gerar a descrição da carta dependendo do número de habilidades que o encantamento tem
        /// </summary>
        /// <param name="numHabilidade">Número gerado por um random, corresponde ao número de habilidades que o encantamento tem</param>
        /// <param name="habilidade1">Número gerado por um random, corresponde à 1º habilidade do encantamento</param>
        /// <param name="habilidade2">Número gerado por um random, corresponde à 2º habilidade do encantamento</param>
        /// <param name="Habilidades">Lista Habilidades</param>
        /// <returns>Retorna a descrição da carta</returns>
        public static string DescricaoEncantamento(int numHabilidade, int habilidade1, int habilidade2, List<Habilidade> Habilidades)
        {
            string descricao;

            if (numHabilidade == 0)
            {
                descricao = "Esta carta não possui habilidades.";
            }
            else if (numHabilidade == 1)
            {
                descricao = "Habilidade 1: " + Habilidades[habilidade1].DescricaoAcao;
            }
            else
            {
                descricao = $"Habilidade 1: " + Habilidades[habilidade1].NomeAcao + ", " + Habilidades[habilidade1].DescricaoAcao + Environment.NewLine + Environment.NewLine;

                descricao += $"Habilidade 2: " + Habilidades[habilidade2].NomeAcao + ", " + Habilidades[habilidade2].DescricaoAcao;
            }

            return descricao;
        }

        /// <summary>
        /// Gerar o dano a infligir ao adversário a partir das habilidades do encantamento
        /// </summary>
        /// <param name="numHabilidade">Número gerado por um random, corresponde ao número de habilidades que o encantamento tem</param>
        /// <param name="habilidade1">Número gerado por um random, corresponde à 1º habilidade do encantamento</param>
        /// <param name="habilidade2">Número gerado por um random, corresponde à 2º habilidade do encantamento</param>
        /// <param name="Habilidades">Lista Habilidades</param>
        /// <returns>Retorna o dano que o encantamento irá infligir ao adversário</returns>
        public static int AcaoEncantamento(int numHabilidade, int habilidade1, int habilidade2, List<Habilidade> Habilidades)
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
