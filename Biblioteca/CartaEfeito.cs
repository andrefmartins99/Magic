using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca
{
    public abstract class CartaEfeito : Carta
    {
        public List<Efeito> Efeitos { get; set; }

        public CartaEfeito(int cor, int custo, int efeito) : base(cor)
        {
            Efeitos = PreencherListaEfeitos();
            CustoCarta = custo;
            NomeCarta = Efeitos[efeito].NomeAcao;
            DescricaoCarta = Efeitos[efeito].DescricaoAcao;
        }

        public List<Efeito> PreencherListaEfeitos()
        {
            Efeitos = new List<Efeito>();
            Efeito efeito1;

            Efeitos.Add(efeito1 = new Efeito("Vento Quente do Sul", "Quentinho mas mortal, oponente perde 3 de HP", -3));
            Efeitos.Add(efeito1 = new Efeito("Canção do Ganso", "Melodia horrenda, ganha 2 de HP", +2));
            Efeitos.Add(efeito1 = new Efeito("Truque do Louva-a-deus", "Corte no dedo mindinho, openente perde 1 de HP", -1));
            Efeitos.Add(efeito1 = new Efeito("Nó no Cérebro", "1 + 1 = 3 (em binário), oponente perde 2 de HP", -2));
            Efeitos.Add(efeito1 = new Efeito("Banho de Lava", "O que arde, cura, ganha 3 de HP", +3));

            return Efeitos;
        }
    }
}
