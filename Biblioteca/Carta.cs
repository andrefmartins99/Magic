using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Biblioteca
{
    enum Cores
    {
        Red,
        Green,
        Blue,
        Black
    }

    public abstract class Carta
    {
        public string TipoCarta { get; set; }

        public string NomeCarta { get; set; }

        public Color CorCarta { get; set; }

        public string DescricaoCarta { get; set; }

        public int CustoCarta { get; set; }

        public Carta(int cor)
        {
            CorCarta = CorDaCarta(cor);
        }

        public Color CorDaCarta(int cor)
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

                default:
                    cores = Cores.Red;
                    break;
            }

            return Color.FromName(cores.ToString());
        }

        public override string ToString()
        {
            return $"{TipoCarta}{Environment.NewLine}" +
                $"{Environment.NewLine}" +
                $"Nome: {NomeCarta}{Environment.NewLine}" +
                $"Cor: {CorCarta}{Environment.NewLine}" +
                $"Custo: {CustoCarta} Mana{Environment.NewLine}" +
                $"{Environment.NewLine}" +
                $"Descrição: {DescricaoCarta}";
        }
    }
}
