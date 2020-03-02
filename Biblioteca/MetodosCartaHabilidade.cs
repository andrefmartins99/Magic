using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca
{
    public static class MetodosCartaHabilidade
    {
        /// <summary>
        /// Preencher a lista Habilidades com habilidades
        /// </summary>
        /// <returns>Retorna a lista Habilidades</returns>
        public static List<Habilidade> PreencherListaHabilidades()
        {
            List<Habilidade> Habilidades = new List<Habilidade>();
            Habilidade habilidade1;

            Habilidades.Add(habilidade1 = new Habilidade("Facada com faca de barrar", "oponente perde 1 de HP", -1));
            Habilidades.Add(habilidade1 = new Habilidade("Pontapé no meio", "oponente perde 5 de HP", -5));
            Habilidades.Add(habilidade1 = new Habilidade("Dentada nos calcanhares", "oponente perde 2 de HP", -2));
            Habilidades.Add(habilidade1 = new Habilidade("Mata-Leoa", "oponente perde 3 de HP", -3));
            Habilidades.Add(habilidade1 = new Habilidade("Cabeçada no cotovelo", "oponente perde 1 de HP", -1));

            return Habilidades;
        }
    }
}
