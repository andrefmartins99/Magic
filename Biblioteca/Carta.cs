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
        Black,
        Orange
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
            CorCarta = MetodosCarta.CorDaCarta(cor);
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
