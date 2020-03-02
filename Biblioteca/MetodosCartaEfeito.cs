using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca
{
    public static class MetodosCartaEfeito
    {
        /// <summary>
        /// Preencher a lista Efeitos com efeitos
        /// </summary>
        /// <returns>Retorna a lista Efeitos</returns>
        public static List<Efeito> PreencherListaEfeitos()
        {
            List<Efeito> Efeitos = new List<Efeito>();
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
