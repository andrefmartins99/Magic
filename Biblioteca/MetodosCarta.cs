using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Biblioteca
{
    public static class MetodosCarta
    {
        /// <summary>
        /// Gerar cor da carta
        /// </summary>
        /// <param name="cor">Número gerado por um random, corresponde à cor da carta</param>
        /// <returns>Retorna a cor da carta</returns>
        public static Color CorDaCarta(int cor)
        {
            Cores cores;

            switch (cor)
            {
                case 0:
                    cores = Cores.Red;
                    break;

                case 1:
                    cores = Cores.Green;
                    break;

                case 2:
                    cores = Cores.Blue;
                    break;

                case 3:
                    cores = Cores.Black;
                    break;

                case 4:
                    cores = Cores.Orange;
                    break;

                default:
                    cores = Cores.Red;
                    break;
            }

            return Color.FromName(cores.ToString());
        }
    }
}
