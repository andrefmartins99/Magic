using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca
{
    enum Cores
    {
        Vermelho,
        Verde,
        Azul,
        Preto
    }

    public abstract class Carta
    {
        public string TipoCarta { get; set; }

        public string NomeCarta { get; set; }

        public string CorCarta { get; set; }

        public string DescricaoCarta { get; set; }

        public int CustoCarta { get; set; }

        public Carta(int cor, int custo)
        {
            CorCarta = CorDaCarta(cor);
            CustoCarta = custo;
        }

        public string CorDaCarta(int cor)
        {
            Cores cores;

            switch (cor)
            {
                case 0:
                    cores = Cores.Vermelho;
                    break;

                case 1:
                    cores = Cores.Verde;
                    break;

                case 2:
                    cores = Cores.Azul;
                    break;

                case 3:
                    cores = Cores.Preto;
                    break;

                default:
                    cores = Cores.Vermelho;
                    break;
            }

            return cores.ToString();
        }

        public override string ToString()
        {
            return $"{TipoCarta}{Environment.NewLine}" +
                $"{Environment.NewLine}" +
                $"Nome: {NomeCarta}{Environment.NewLine}" +
                $"Cor: {CorCarta}{Environment.NewLine}" +
                $"Custo: {CustoCarta}{Environment.NewLine}" +
                $"{Environment.NewLine}" +
                $"Descrição: {DescricaoCarta}";
        }
    }
}
