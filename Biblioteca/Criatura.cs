using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca
{
    public abstract class Criatura : CartaHabilidade
    {
        public int AtaqueCriatura { get; set; }

        public int DefesaCriatura { get; set; }

        public Criatura(int cor, int custo, int numHabilidade, int habilidade1, int habilidade2, int ataque, int defesa, List<Habilidade> Habilidades) : base(cor, custo, Habilidades)
        {
            TipoCarta = "Criatura";
            AcaoHabilidade = MetodosCriatura.AcaoCriatura(numHabilidade, habilidade1, habilidade2, Habilidades);
            AtaqueCriatura = ataque;
            DefesaCriatura = defesa;
        }

        public override string ToString()
        {
            return $"{TipoCarta}{Environment.NewLine}" +
                $"{Environment.NewLine}" +
                $"Nome: {NomeCarta}{Environment.NewLine}" +
                $"Cor: {CorCarta}{Environment.NewLine}" +
                $"Custo: {CustoCarta} Mana{Environment.NewLine}" +
                $"{Environment.NewLine}" +
                $"{DescricaoCarta}{Environment.NewLine}" +
                $"{Environment.NewLine}" +
                $"Ataque/Defesa: {AtaqueCriatura}/{DefesaCriatura}";
        }
    }
}
