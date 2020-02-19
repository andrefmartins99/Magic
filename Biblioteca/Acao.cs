using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca
{
    public abstract class Acao
    {
        public string NomeAcao { get; set; }

        public string DescricaoAcao { get; set; }

        public int AcaoAcao { get; set; }

        public Acao(string nome, string descricao, int acao)
        {
            NomeAcao = nome;
            DescricaoAcao = descricao;
            AcaoAcao = acao;
        }
    }
}
