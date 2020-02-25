using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca
{
    public abstract class CartaHabilidade : Carta
    {
        public int AcaoHabilidade { get; set; }

        public List<Habilidade> Habilidades { get; set; }

        public CartaHabilidade(int cor, int custo) : base(cor)
        {
            Habilidades = PreencherListaHabilidades();
            CustoCarta = custo;
        }

        public List<Habilidade> PreencherListaHabilidades()
        {
            Habilidades = new List<Habilidade>();
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
