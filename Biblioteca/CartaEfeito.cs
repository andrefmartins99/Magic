using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca
{
    public abstract class CartaEfeito : Carta
    {
        public List<Efeito> Efeitos { get; }

        public int AcaoEfeito { get; set; }

        public CartaEfeito(int cor, int custo, int efeito, List<Efeito> efeitos) : base(cor, custo)
        {
            Efeitos = efeitos;
            NomeCarta = Efeitos[efeito].NomeAcao;
            DescricaoCarta = Efeitos[efeito].DescricaoAcao;
            AcaoEfeito = Efeitos[efeito].AcaoAcao;
        }
    }
}
