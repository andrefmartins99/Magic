using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca
{
    public static class MetodosTerreno
    {
        /// <summary>
        /// Gerar o nome da carta
        /// </summary>
        /// <param name="nome">Número gerado por um random, corresponde ao nome da carta</param>
        /// <returns>Retorna o nome da carta</returns>
        public static string NomeDaCarta(int nome)
        {
            string nomes;

            switch (nome)
            {
                case 0:
                    nomes = "Deserto";
                    break;

                case 1:
                    nomes = "Oceano";
                    break;

                default:
                    nomes = "Deserto";
                    break;
            }

            return nomes;
        }

        /// <summary>
        /// Gerar a descrição da carta
        /// </summary>
        /// <param name="nome">Número gerado por um random, corresponde ao nome da carta</param>
        /// <param name="desc">Número gerado por um random, corresponde à descrição da carta</param>
        /// <returns>Retorna a descrição da carta</returns>
        public static string DescricaoDaCarta(int nome, int desc)
        {
            string descricao;

            switch (nome)
            {
                case 0:

                    switch (desc)
                    {
                        case 0:
                            descricao = "O primeiro registo de neve no Deserto do Saara foi em 1979.";
                            break;

                        case 1:
                            descricao = "O maior deserto do mundo é o Deserto Polar Antártico com 13 829 430 km quadrados.";
                            break;

                        case 2:
                            descricao = "O segundo maior deserto do mundo é o Deserto Polar Ártico com 13 726 937 km quadrados.";
                            break;

                        default:
                            descricao = "O primeiro registo de neve no Deserto do Saara foi em 1979.";
                            break;
                    }

                    break;

                case 1:

                    switch (desc)
                    {
                        case 0:
                            descricao = "A maior parte do oxigénio da Terra é produzido não pelas árvores, mas pelas algas marinhas.";
                            break;

                        case 1:
                            descricao = "70% da Terra está coberta por água, e desses 70% apenas 5% foram explorados pelo ser humano.";
                            break;

                        case 2:
                            descricao = "O oceano Pacífico foi assim batizado por Fernão de Magalhães, por este o ter achado tranquilo.";
                            break;

                        default:
                            descricao = "O oceano Pacífico foi assim batizado por Fernão de Magalhães, por este o ter achado tranquilo.";
                            break;
                    }

                    break;

                default:

                    switch (desc)
                    {
                        case 0:
                            descricao = "O primeiro registo de neve no Deserto do Saara foi em 1979.";
                            break;

                        case 1:
                            descricao = "O maior deserto do mundo é o Deserto Polar Antártico com 13 829 430 km quadrados.";
                            break;

                        case 2:
                            descricao = "O segundo maior deserto do mundo é o Deserto Polar Ártico com 13 726 937 km quadrados.";
                            break;

                        default:
                            descricao = "O primeiro registo de neve no Deserto do Saara foi em 1979.";
                            break;
                    }

                    break;
            }

            return descricao;
        }
    }
}
