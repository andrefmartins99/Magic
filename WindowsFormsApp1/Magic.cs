using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca;

namespace WindowsFormsApp1
{
    public partial class Magic : Form
    {
        public Magic()
        {
            InitializeComponent();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            Random rng = new Random();
            int rnd;

            rnd = rng.Next(1, 9);

            switch (rnd)
            {
                case 1:
                    Terreno cartaTerreno;
                    cartaTerreno = CriarCartaTerreno();
                    ExibeTerreno(cartaTerreno);
                    break;

                case 2:
                    Feitico cartaFeitico;
                    cartaFeitico = CriarCartaFeitico();
                    ExibeFeitico(cartaFeitico);
                    break;

                case 3:
                    MagicaInstantanea cartaMagicaInstantanea;
                    cartaMagicaInstantanea = CriarCartaMagicaInstantanea();
                    ExibeMagicaInstantanea(cartaMagicaInstantanea);
                    break;

                case 4:
                    Encantamento cartaEncantamento;
                    cartaEncantamento = CriarCartaEncantamento();
                    ExibeEncantamento(cartaEncantamento);
                    break;

                case 5:
                    Elfo cartaCriaturaElfo;
                    cartaCriaturaElfo = CriarCartaCriaturaElfo();
                    ExibeCriaturaElfo(cartaCriaturaElfo);
                    break;

                case 6:
                    Humano cartaCriaturaHumano;
                    cartaCriaturaHumano = CriarCartaCriaturaHumano();
                    ExibeCriaturaHumano(cartaCriaturaHumano);
                    break;

                case 7:
                    Orc cartaCriaturaOrc;
                    cartaCriaturaOrc = CriarCartaCriaturaOrc();
                    ExibeCriaturaOrc(cartaCriaturaOrc);
                    break;

                case 8:
                    Anao cartaCriaturaAnao;
                    cartaCriaturaAnao = CriarCartaCriaturaAnao();
                    ExibeCriaturaAnao(cartaCriaturaAnao);
                    break;

                default:
                    Humano cartaCriaturaHumanoDefault;
                    cartaCriaturaHumanoDefault = CriarCartaCriaturaHumano();
                    ExibeCriaturaHumano(cartaCriaturaHumanoDefault);
                    break;
            }

            panel1.Visible = true;
            panel2.Visible = true;
        }

        public Terreno CriarCartaTerreno()
        {
            Random rng = new Random();
            int nome, cor, desc;

            nome = rng.Next(0, 2);
            cor = rng.Next(0, 4);
            desc = rng.Next(0, 3);

            Terreno cartaTerreno = new Terreno(nome, cor, desc);

            return cartaTerreno;
        }

        public Feitico CriarCartaFeitico()
        {
            Random rng = new Random();
            int cor, custo, efeito;

            cor = rng.Next(0, 4);
            custo = rng.Next(1, 6);
            efeito = rng.Next(0, 5);

            Feitico cartaFeitico = new Feitico(cor, custo, efeito);

            return cartaFeitico;
        }

        public MagicaInstantanea CriarCartaMagicaInstantanea()
        {
            Random rng = new Random();
            int cor, custo, efeito;

            cor = rng.Next(0, 4);
            custo = rng.Next(1, 6);
            efeito = rng.Next(0, 5);

            MagicaInstantanea cartaMagicaInstantanea = new MagicaInstantanea(cor, custo, efeito);

            return cartaMagicaInstantanea;
        }

        public Encantamento CriarCartaEncantamento()
        {
            Random rng = new Random();
            int cor, custo, numHabilidade, habilidade;

            cor = rng.Next(0, 4);
            custo = rng.Next(1, 6);
            numHabilidade = rng.Next(0, 3);
            habilidade = rng.Next(0, 5);

            Encantamento cartaEncantamento = new Encantamento(cor, custo, numHabilidade, habilidade);

            return cartaEncantamento;
        }

        public Elfo CriarCartaCriaturaElfo()
        {
            Random rng = new Random();
            int cor, custo, numHabilidade, habilidade, descricao, ataque, defesa;

            cor = rng.Next(0, 4);
            custo = rng.Next(1, 6);
            numHabilidade = rng.Next(0, 3);
            habilidade = rng.Next(0, 5);
            descricao = rng.Next(0, 5);
            ataque = rng.Next(0, 6);
            defesa = rng.Next(0, 6);

            Elfo cartaCriaturaElfo = new Elfo(cor, custo, numHabilidade, habilidade, descricao, ataque, defesa);

            return cartaCriaturaElfo;
        }

        public Humano CriarCartaCriaturaHumano()
        {
            Random rng = new Random();
            int cor, custo, numHabilidade, habilidade, descricao, ataque, defesa;

            cor = rng.Next(0, 4);
            custo = rng.Next(1, 6);
            numHabilidade = rng.Next(0, 3);
            habilidade = rng.Next(0, 5);
            descricao = rng.Next(0, 5);
            ataque = rng.Next(0, 6);
            defesa = rng.Next(0, 6);

            Humano cartaCriaturaHumano = new Humano(cor, custo, numHabilidade, habilidade, descricao, ataque, defesa);

            return cartaCriaturaHumano;
        }

        public Orc CriarCartaCriaturaOrc()
        {
            Random rng = new Random();
            int cor, custo, numHabilidade, habilidade, descricao, ataque, defesa;

            cor = rng.Next(0, 4);
            custo = rng.Next(1, 6);
            numHabilidade = rng.Next(0, 3);
            habilidade = rng.Next(0, 5);
            descricao = rng.Next(0, 5);
            ataque = rng.Next(0, 6);
            defesa = rng.Next(0, 6);

            Orc cartaCriaturaOrc = new Orc(cor, custo, numHabilidade, habilidade, descricao, ataque, defesa);

            return cartaCriaturaOrc;
        }

        public Anao CriarCartaCriaturaAnao()
        {
            Random rng = new Random();
            int cor, custo, numHabilidade, habilidade, descricao, ataque, defesa;

            cor = rng.Next(0, 4);
            custo = rng.Next(1, 6);
            numHabilidade = rng.Next(0, 3);
            habilidade = rng.Next(0, 5);
            descricao = rng.Next(0, 5);
            ataque = rng.Next(0, 6);
            defesa = rng.Next(0, 6);

            Anao cartaCriaturaAnao = new Anao(cor, custo, numHabilidade, habilidade, descricao, ataque, defesa);

            return cartaCriaturaAnao;
        }

        public void ExibeTerreno(Terreno cartaTerreno)
        {
            string tipoCarta, nomeCarta, descricaoCarta;
            int custoCarta;
            Color corCarta;

            tipoCarta = cartaTerreno.TipoCarta;
            nomeCarta = cartaTerreno.NomeCarta;
            corCarta = cartaTerreno.CorCarta;
            custoCarta = cartaTerreno.CustoCarta;
            descricaoCarta = cartaTerreno.DescricaoCarta;

            ExibeCartaNaoCriatura(tipoCarta, nomeCarta, corCarta, descricaoCarta, custoCarta);
        }

        public void ExibeFeitico(Feitico cartaFeitico)
        {
            string tipoCarta, nomeCarta, descricaoCarta;
            int custoCarta;
            Color corCarta;

            tipoCarta = cartaFeitico.TipoCarta;
            nomeCarta = cartaFeitico.NomeCarta;
            corCarta = cartaFeitico.CorCarta;
            custoCarta = cartaFeitico.CustoCarta;
            descricaoCarta = cartaFeitico.DescricaoCarta;

            ExibeCartaNaoCriatura(tipoCarta, nomeCarta, corCarta, descricaoCarta, custoCarta);
        }

        public void ExibeMagicaInstantanea(MagicaInstantanea cartaMagicaInstantanea)
        {
            string tipoCarta, nomeCarta, descricaoCarta;
            int custoCarta;
            Color corCarta;

            tipoCarta = cartaMagicaInstantanea.TipoCarta;
            nomeCarta = cartaMagicaInstantanea.NomeCarta;
            corCarta = cartaMagicaInstantanea.CorCarta;
            custoCarta = cartaMagicaInstantanea.CustoCarta;
            descricaoCarta = cartaMagicaInstantanea.DescricaoCarta;

            ExibeCartaNaoCriatura(tipoCarta, nomeCarta, corCarta, descricaoCarta, custoCarta);
        }

        public void ExibeEncantamento(Encantamento cartaEncantamento)
        {
            string tipoCarta, nomeCarta, descricaoCarta;
            int custoCarta;
            Color corCarta;

            tipoCarta = cartaEncantamento.TipoCarta;
            nomeCarta = cartaEncantamento.NomeCarta;
            corCarta = cartaEncantamento.CorCarta;
            custoCarta = cartaEncantamento.CustoCarta;
            descricaoCarta = cartaEncantamento.DescricaoCarta;

            ExibeCartaNaoCriatura(tipoCarta, nomeCarta, corCarta, descricaoCarta, custoCarta);
        }

        public void ExibeCriaturaElfo(Elfo cartaCriaturaElfo)
        {
            string tipoCarta, nomeCarta, descricaoCarta;
            int custoCarta, ataqueCriatura, defesaCriatura;
            Color corCarta;

            tipoCarta = cartaCriaturaElfo.TipoCarta;
            nomeCarta = cartaCriaturaElfo.NomeCarta;
            corCarta = cartaCriaturaElfo.CorCarta;
            custoCarta = cartaCriaturaElfo.CustoCarta;
            descricaoCarta = cartaCriaturaElfo.DescricaoCarta;
            ataqueCriatura = cartaCriaturaElfo.AtaqueCriatura;
            defesaCriatura = cartaCriaturaElfo.DefesaCriatura;

            ExibeCartaCriatura(tipoCarta, nomeCarta, corCarta, descricaoCarta, custoCarta, ataqueCriatura, defesaCriatura);
        }

        public void ExibeCriaturaHumano(Humano cartaCriaturaHumano)
        {
            string tipoCarta, nomeCarta, descricaoCarta;
            int custoCarta, ataqueCriatura, defesaCriatura;
            Color corCarta;

            tipoCarta = cartaCriaturaHumano.TipoCarta;
            nomeCarta = cartaCriaturaHumano.NomeCarta;
            corCarta = cartaCriaturaHumano.CorCarta;
            custoCarta = cartaCriaturaHumano.CustoCarta;
            descricaoCarta = cartaCriaturaHumano.DescricaoCarta;
            ataqueCriatura = cartaCriaturaHumano.AtaqueCriatura;
            defesaCriatura = cartaCriaturaHumano.DefesaCriatura;

            ExibeCartaCriatura(tipoCarta, nomeCarta, corCarta, descricaoCarta, custoCarta, ataqueCriatura, defesaCriatura);
        }

        public void ExibeCriaturaOrc(Orc cartaCriaturaOrc)
        {
            string tipoCarta, nomeCarta, descricaoCarta;
            int custoCarta, ataqueCriatura, defesaCriatura;
            Color corCarta;

            tipoCarta = cartaCriaturaOrc.TipoCarta;
            nomeCarta = cartaCriaturaOrc.NomeCarta;
            corCarta = cartaCriaturaOrc.CorCarta;
            custoCarta = cartaCriaturaOrc.CustoCarta;
            descricaoCarta = cartaCriaturaOrc.DescricaoCarta;
            ataqueCriatura = cartaCriaturaOrc.AtaqueCriatura;
            defesaCriatura = cartaCriaturaOrc.DefesaCriatura;

            ExibeCartaCriatura(tipoCarta, nomeCarta, corCarta, descricaoCarta, custoCarta, ataqueCriatura, defesaCriatura);
        }

        public void ExibeCriaturaAnao(Anao cartaCriaturaAnao)
        {
            string tipoCarta, nomeCarta, descricaoCarta;
            int custoCarta, ataqueCriatura, defesaCriatura;
            Color corCarta;

            tipoCarta = cartaCriaturaAnao.TipoCarta;
            nomeCarta = cartaCriaturaAnao.NomeCarta;
            corCarta = cartaCriaturaAnao.CorCarta;
            custoCarta = cartaCriaturaAnao.CustoCarta;
            descricaoCarta = cartaCriaturaAnao.DescricaoCarta;
            ataqueCriatura = cartaCriaturaAnao.AtaqueCriatura;
            defesaCriatura = cartaCriaturaAnao.DefesaCriatura;

            ExibeCartaCriatura(tipoCarta, nomeCarta, corCarta, descricaoCarta, custoCarta, ataqueCriatura, defesaCriatura);
        }

        public void ExibeCartaNaoCriatura(string tipoCarta, string nomeCarta, Color corCarta, string descricaoCarta, int custoCarta)
        {
            lblStats1.Visible = false;
            lblNome1.Text = nomeCarta;
            lblCusto1.Text = custoCarta.ToString() + " Mana";
            lblTipo1.Text = tipoCarta;
            lblDescricao1.Text = descricaoCarta;
            panel1.BackColor = corCarta;
        }

        public void ExibeCartaCriatura(string tipoCarta, string nomeCarta, Color corCarta, string descricaoCarta, int custoCarta, int ataqueCriatura, int defesaCriatura)
        {
            lblStats1.Visible = true;
            lblNome1.Text = nomeCarta;
            lblCusto1.Text = custoCarta.ToString() + " Mana";
            lblTipo1.Text = tipoCarta;
            lblDescricao1.Text = descricaoCarta;
            lblStats1.Text = "Ataque/Defesa: " + ataqueCriatura + "/" + defesaCriatura;
            panel1.BackColor = corCarta;
        }
    }
}
