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
        int acaoEfeito1, acaoEfeito2, acaoHabilidade1, acaoHabilidade2, ataque1, ataque2, vida1, vida2;

        public Magic()
        {
            InitializeComponent();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            Random rng = new Random();
            int rnd, numCarta = 1;
            acaoEfeito1 = 0;
            acaoEfeito2 = 0;
            acaoHabilidade1 = 0;
            acaoHabilidade2 = 0;
            ataque1 = 0;
            ataque2 = 0;

            do
            {
                rnd = rng.Next(1, 9);

                switch (rnd)
                {
                    case 1:
                        Terreno cartaTerreno;
                        cartaTerreno = CriarCartaTerreno();
                        ExibeTerreno(cartaTerreno, numCarta);
                        break;

                    case 2:
                        Feitico cartaFeitico;
                        cartaFeitico = CriarCartaFeitico(numCarta, ref acaoEfeito1, ref acaoEfeito2);
                        ExibeFeitico(cartaFeitico, numCarta);
                        break;

                    case 3:
                        MagicaInstantanea cartaMagicaInstantanea;
                        cartaMagicaInstantanea = CriarCartaMagicaInstantanea(numCarta, ref acaoEfeito1, ref acaoEfeito2);
                        ExibeMagicaInstantanea(cartaMagicaInstantanea, numCarta);
                        break;

                    case 4:
                        Encantamento cartaEncantamento;
                        cartaEncantamento = CriarCartaEncantamento(numCarta, ref acaoHabilidade1, ref acaoHabilidade2);
                        ExibeEncantamento(cartaEncantamento, numCarta);
                        break;

                    case 5:
                        Elfo cartaCriaturaElfo;
                        cartaCriaturaElfo = CriarCartaCriaturaElfo(numCarta, ref acaoHabilidade1, ref acaoHabilidade2, ref ataque1, ref ataque2);
                        ExibeCriaturaElfo(cartaCriaturaElfo, numCarta);
                        break;

                    case 6:
                        Humano cartaCriaturaHumano;
                        cartaCriaturaHumano = CriarCartaCriaturaHumano(numCarta, ref acaoHabilidade1, ref acaoHabilidade2, ref ataque1, ref ataque2);
                        ExibeCriaturaHumano(cartaCriaturaHumano, numCarta);
                        break;

                    case 7:
                        Orc cartaCriaturaOrc;
                        cartaCriaturaOrc = CriarCartaCriaturaOrc(numCarta, ref acaoHabilidade1, ref acaoHabilidade2, ref ataque1, ref ataque2);
                        ExibeCriaturaOrc(cartaCriaturaOrc, numCarta);
                        break;

                    case 8:
                        Anao cartaCriaturaAnao;
                        cartaCriaturaAnao = CriarCartaCriaturaAnao(numCarta, ref acaoHabilidade1, ref acaoHabilidade2, ref ataque1, ref ataque2);
                        ExibeCriaturaAnao(cartaCriaturaAnao, numCarta);
                        break;

                    default:
                        Humano cartaCriaturaHumanoDefault;
                        cartaCriaturaHumanoDefault = CriarCartaCriaturaHumano(numCarta, ref acaoHabilidade1, ref acaoHabilidade2, ref ataque1, ref ataque2);
                        ExibeCriaturaHumano(cartaCriaturaHumanoDefault, numCarta);
                        break;
                }

                numCarta++;

            } while (numCarta <= 2);

            btnGerar.Enabled = false;
            btnLutar.Enabled = true;
        }

        public Terreno CriarCartaTerreno()
        {
            Random rng = new Random();
            int nome, cor, desc;

            nome = rng.Next(0, 2);
            cor = rng.Next(0, 5);
            desc = rng.Next(0, 3);

            Terreno cartaTerreno = new Terreno(nome, cor, desc);

            return cartaTerreno;
        }

        public Feitico CriarCartaFeitico(int numCarta, ref int acaoEfeito1, ref int acaoEfeito2)
        {
            Random rng = new Random();
            int cor, custo, efeito;

            cor = rng.Next(0, 5);
            custo = rng.Next(1, 6);
            efeito = rng.Next(0, 5);

            Feitico cartaFeitico = new Feitico(cor, custo, efeito);

            if (numCarta == 1)
            {
                acaoEfeito1 = cartaFeitico.AcaoEfeito;
            }
            else
            {
                acaoEfeito2 = cartaFeitico.AcaoEfeito;
            }

            return cartaFeitico;
        }

        public MagicaInstantanea CriarCartaMagicaInstantanea(int numCarta, ref int acaoEfeito1, ref int acaoEfeito2)
        {
            Random rng = new Random();
            int cor, custo, efeito;

            cor = rng.Next(0, 5);
            custo = rng.Next(1, 6);
            efeito = rng.Next(0, 5);

            MagicaInstantanea cartaMagicaInstantanea = new MagicaInstantanea(cor, custo, efeito);

            if (numCarta == 1)
            {
                acaoEfeito1 = cartaMagicaInstantanea.AcaoEfeito;
            }
            else
            {
                acaoEfeito2 = cartaMagicaInstantanea.AcaoEfeito;
            }

            return cartaMagicaInstantanea;
        }

        public Encantamento CriarCartaEncantamento(int numCarta, ref int acaoHabilidade1, ref int acaoHabilidade2)
        {
            Random rng = new Random();
            int cor, custo, numHabilidade, habilidade1, habilidade2;

            cor = rng.Next(0, 5);
            custo = rng.Next(1, 6);
            numHabilidade = rng.Next(0, 3);
            habilidade1 = rng.Next(0, 5);

            do
            {
                habilidade2 = rng.Next(0, 5);

            } while (habilidade2 == habilidade1);

            Encantamento cartaEncantamento = new Encantamento(cor, custo, numHabilidade, habilidade1, habilidade2);

            if (numCarta == 1)
            {
                acaoHabilidade1 = cartaEncantamento.AcaoHabilidade;
            }
            else
            {
                acaoHabilidade2 = cartaEncantamento.AcaoHabilidade;
            }

            return cartaEncantamento;
        }

        public Elfo CriarCartaCriaturaElfo(int numCarta, ref int acaoHabilidade1, ref int acaoHabilidade2, ref int ataque1, ref int ataque2)
        {
            Random rng = new Random();
            int cor, custo, numHabilidade, habilidade1, habilidade2, descricao, ataque, defesa;

            cor = rng.Next(0, 5);
            custo = rng.Next(1, 6);
            numHabilidade = rng.Next(0, 3);
            habilidade1 = rng.Next(0, 5);
            descricao = rng.Next(0, 5);
            ataque = rng.Next(1, 6);
            defesa = rng.Next(1, 6);

            do
            {
                habilidade2 = rng.Next(0, 5);

            } while (habilidade2 == habilidade1);

            Elfo cartaCriaturaElfo = new Elfo(cor, custo, numHabilidade, habilidade1, habilidade2, descricao, ataque, defesa);

            if (numCarta == 1)
            {
                acaoHabilidade1 = cartaCriaturaElfo.AcaoHabilidade;
                ataque1 = cartaCriaturaElfo.AtaqueCriatura;
            }
            else
            {
                acaoHabilidade2 = cartaCriaturaElfo.AcaoHabilidade;
                ataque2 = cartaCriaturaElfo.AtaqueCriatura;
            }

            return cartaCriaturaElfo;
        }

        public Humano CriarCartaCriaturaHumano(int numCarta, ref int acaoHabilidade1, ref int acaoHabilidade2, ref int ataque1, ref int ataque2)
        {
            Random rng = new Random();
            int cor, custo, numHabilidade, habilidade1, habilidade2, descricao, ataque, defesa;

            cor = rng.Next(0, 5);
            custo = rng.Next(1, 6);
            numHabilidade = rng.Next(0, 3);
            habilidade1 = rng.Next(0, 5);
            descricao = rng.Next(0, 5);
            ataque = rng.Next(1, 6);
            defesa = rng.Next(1, 6);

            do
            {
                habilidade2 = rng.Next(0, 5);

            } while (habilidade2 == habilidade1);

            Humano cartaCriaturaHumano = new Humano(cor, custo, numHabilidade, habilidade1, habilidade2, descricao, ataque, defesa);

            if (numCarta == 1)
            {
                acaoHabilidade1 = cartaCriaturaHumano.AcaoHabilidade;
                ataque1 = cartaCriaturaHumano.AtaqueCriatura;
            }
            else
            {
                acaoHabilidade2 = cartaCriaturaHumano.AcaoHabilidade;
                ataque2 = cartaCriaturaHumano.AtaqueCriatura;
            }

            return cartaCriaturaHumano;
        }

        public Orc CriarCartaCriaturaOrc(int numCarta, ref int acaoHabilidade1, ref int acaoHabilidade2, ref int ataque1, ref int ataque2)
        {
            Random rng = new Random();
            int cor, custo, numHabilidade, habilidade1, habilidade2, descricao, ataque, defesa;

            cor = rng.Next(0, 5);
            custo = rng.Next(1, 6);
            numHabilidade = rng.Next(0, 3);
            habilidade1 = rng.Next(0, 5);
            descricao = rng.Next(0, 5);
            ataque = rng.Next(1, 6);
            defesa = rng.Next(1, 6);

            do
            {
                habilidade2 = rng.Next(0, 5);

            } while (habilidade2 == habilidade1);

            Orc cartaCriaturaOrc = new Orc(cor, custo, numHabilidade, habilidade1, habilidade2, descricao, ataque, defesa);

            if (numCarta == 1)
            {
                acaoHabilidade1 = cartaCriaturaOrc.AcaoHabilidade;
                ataque1 = cartaCriaturaOrc.AtaqueCriatura;
            }
            else
            {
                acaoHabilidade2 = cartaCriaturaOrc.AcaoHabilidade;
                ataque2 = cartaCriaturaOrc.AtaqueCriatura;
            }

            return cartaCriaturaOrc;
        }

        public Anao CriarCartaCriaturaAnao(int numCarta, ref int acaoHabilidade1, ref int acaoHabilidade2, ref int ataque1, ref int ataque2)
        {
            Random rng = new Random();
            int cor, custo, numHabilidade, habilidade1, habilidade2, descricao, ataque, defesa;

            cor = rng.Next(0, 5);
            custo = rng.Next(1, 6);
            numHabilidade = rng.Next(0, 3);
            habilidade1 = rng.Next(0, 5);
            descricao = rng.Next(0, 5);
            ataque = rng.Next(1, 6);
            defesa = rng.Next(1, 6);

            do
            {
                habilidade2 = rng.Next(0, 5);

            } while (habilidade2 == habilidade1);

            Anao cartaCriaturaAnao = new Anao(cor, custo, numHabilidade, habilidade1, habilidade2, descricao, ataque, defesa);

            if (numCarta == 1)
            {
                acaoHabilidade1 = cartaCriaturaAnao.AcaoHabilidade;
                ataque1 = cartaCriaturaAnao.AtaqueCriatura;
            }
            else
            {
                acaoHabilidade2 = cartaCriaturaAnao.AcaoHabilidade;
                ataque2 = cartaCriaturaAnao.AtaqueCriatura;
            }

            return cartaCriaturaAnao;
        }

        public void ExibeTerreno(Terreno cartaTerreno, int numCarta)
        {
            string tipoCarta, nomeCarta, descricaoCarta;
            int custoCarta;
            Color corCarta;

            tipoCarta = cartaTerreno.TipoCarta;
            nomeCarta = cartaTerreno.NomeCarta;
            corCarta = cartaTerreno.CorCarta;
            custoCarta = cartaTerreno.CustoCarta;
            descricaoCarta = cartaTerreno.DescricaoCarta;

            if (numCarta == 1)
            {
                ExibeCarta1NaoCriatura(tipoCarta, nomeCarta, corCarta, descricaoCarta, custoCarta);
            }
            else
            {
                ExibeCarta2NaoCriatura(tipoCarta, nomeCarta, corCarta, descricaoCarta, custoCarta);
            }
        }

        public void ExibeFeitico(Feitico cartaFeitico, int numCarta)
        {
            string tipoCarta, nomeCarta, descricaoCarta;
            int custoCarta;
            Color corCarta;

            tipoCarta = cartaFeitico.TipoCarta;
            nomeCarta = cartaFeitico.NomeCarta;
            corCarta = cartaFeitico.CorCarta;
            custoCarta = cartaFeitico.CustoCarta;
            descricaoCarta = cartaFeitico.DescricaoCarta;

            if (numCarta == 1)
            {
                ExibeCarta1NaoCriatura(tipoCarta, nomeCarta, corCarta, descricaoCarta, custoCarta);
            }
            else
            {
                ExibeCarta2NaoCriatura(tipoCarta, nomeCarta, corCarta, descricaoCarta, custoCarta);
            }
        }

        public void ExibeMagicaInstantanea(MagicaInstantanea cartaMagicaInstantanea, int numCarta)
        {
            string tipoCarta, nomeCarta, descricaoCarta;
            int custoCarta;
            Color corCarta;

            tipoCarta = cartaMagicaInstantanea.TipoCarta;
            nomeCarta = cartaMagicaInstantanea.NomeCarta;
            corCarta = cartaMagicaInstantanea.CorCarta;
            custoCarta = cartaMagicaInstantanea.CustoCarta;
            descricaoCarta = cartaMagicaInstantanea.DescricaoCarta;

            if (numCarta == 1)
            {
                ExibeCarta1NaoCriatura(tipoCarta, nomeCarta, corCarta, descricaoCarta, custoCarta);
            }
            else
            {
                ExibeCarta2NaoCriatura(tipoCarta, nomeCarta, corCarta, descricaoCarta, custoCarta);
            }
        }

        public void ExibeEncantamento(Encantamento cartaEncantamento, int numCarta)
        {
            string tipoCarta, nomeCarta, descricaoCarta;
            int custoCarta;
            Color corCarta;

            tipoCarta = cartaEncantamento.TipoCarta;
            nomeCarta = cartaEncantamento.NomeCarta;
            corCarta = cartaEncantamento.CorCarta;
            custoCarta = cartaEncantamento.CustoCarta;
            descricaoCarta = cartaEncantamento.DescricaoCarta;

            if (numCarta == 1)
            {
                ExibeCarta1NaoCriatura(tipoCarta, nomeCarta, corCarta, descricaoCarta, custoCarta);
            }
            else
            {
                ExibeCarta2NaoCriatura(tipoCarta, nomeCarta, corCarta, descricaoCarta, custoCarta);
            }
        }

        public void ExibeCriaturaElfo(Elfo cartaCriaturaElfo, int numCarta)
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

            if (numCarta == 1)
            {
                ExibeCarta1Criatura(tipoCarta, nomeCarta, corCarta, descricaoCarta, custoCarta, ataqueCriatura, defesaCriatura);
            }
            else
            {
                ExibeCarta2Criatura(tipoCarta, nomeCarta, corCarta, descricaoCarta, custoCarta, ataqueCriatura, defesaCriatura);
            }
        }

        public void ExibeCriaturaHumano(Humano cartaCriaturaHumano, int numCarta)
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

            if (numCarta == 1)
            {
                ExibeCarta1Criatura(tipoCarta, nomeCarta, corCarta, descricaoCarta, custoCarta, ataqueCriatura, defesaCriatura);
            }
            else
            {
                ExibeCarta2Criatura(tipoCarta, nomeCarta, corCarta, descricaoCarta, custoCarta, ataqueCriatura, defesaCriatura);
            }
        }

        public void ExibeCriaturaOrc(Orc cartaCriaturaOrc, int numCarta)
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

            if (numCarta == 1)
            {
                ExibeCarta1Criatura(tipoCarta, nomeCarta, corCarta, descricaoCarta, custoCarta, ataqueCriatura, defesaCriatura);
            }
            else
            {
                ExibeCarta2Criatura(tipoCarta, nomeCarta, corCarta, descricaoCarta, custoCarta, ataqueCriatura, defesaCriatura);
            }
        }

        private void btnLutar_Click(object sender, EventArgs e)
        {
            if (acaoEfeito1 > 0 && acaoEfeito2 > 0)
            {
                vida1 += acaoEfeito1;
                vida2 += acaoEfeito2;

                AtualizarVidaJogadores(vida1, vida2);
            }
            else if (acaoEfeito1 > 0)
            {
                vida1 += acaoEfeito1;
                AtualizarVidaJogadores(vida1, vida2);

                vida1 += acaoHabilidade2;
                AtualizarVidaJogadores(vida1, vida2);
                FinalizarJogo(ref vida1, ref vida2);

                vida1 -= ataque2;
                AtualizarVidaJogadores(vida1, vida2);
                FinalizarJogo(ref vida1, ref vida2);
            }
            else if (acaoEfeito2 > 0)
            {
                vida2 += acaoEfeito2;

                vida2 += acaoHabilidade1;
                AtualizarVidaJogadores(vida1, vida2);
                FinalizarJogo(ref vida1, ref vida2);

                vida2 -= ataque1;
                AtualizarVidaJogadores(vida1, vida2);
                FinalizarJogo(ref vida1, ref vida2);
            }
            else
            {
                vida1 += acaoEfeito2;
                AtualizarVidaJogadores(vida1, vida2);
                FinalizarJogo(ref vida1, ref vida2);
                vida2 += acaoEfeito1;
                AtualizarVidaJogadores(vida1, vida2);
                FinalizarJogo(ref vida1, ref vida2);

                vida1 += acaoHabilidade2;
                AtualizarVidaJogadores(vida1, vida2);
                FinalizarJogo(ref vida1, ref vida2);
                vida2 += acaoHabilidade1;
                AtualizarVidaJogadores(vida1, vida2);
                FinalizarJogo(ref vida1, ref vida2);

                if (ataque1 > ataque2)
                {
                    vida2 -= (ataque1 - ataque2);
                    AtualizarVidaJogadores(vida1, vida2);
                    FinalizarJogo(ref vida1, ref vida2);
                }
                else if (ataque1 < ataque2)
                {
                    vida1 -= (ataque2 - ataque1);
                    AtualizarVidaJogadores(vida1, vida2);
                    FinalizarJogo(ref vida1, ref vida2);
                }
            }

            btnGerar.Enabled = true;
            btnLutar.Enabled = false;
        }

        public void ExibeCriaturaAnao(Anao cartaCriaturaAnao, int numCarta)
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

            if (numCarta == 1)
            {
                ExibeCarta1Criatura(tipoCarta, nomeCarta, corCarta, descricaoCarta, custoCarta, ataqueCriatura, defesaCriatura);
            }
            else
            {
                ExibeCarta2Criatura(tipoCarta, nomeCarta, corCarta, descricaoCarta, custoCarta, ataqueCriatura, defesaCriatura);
            }
        }

        public void ExibeCarta1NaoCriatura(string tipoCarta, string nomeCarta, Color corCarta, string descricaoCarta, int custoCarta)
        {
            lblStats1.Visible = false;
            lblNome1.Text = nomeCarta;
            lblCusto1.Text = custoCarta.ToString() + " Mana";
            lblTipo1.Text = tipoCarta;
            lblDescricao1.Text = descricaoCarta;
            panel1.BackColor = corCarta;
        }

        public void ExibeCarta1Criatura(string tipoCarta, string nomeCarta, Color corCarta, string descricaoCarta, int custoCarta, int ataqueCriatura, int defesaCriatura)
        {
            lblStats1.Visible = true;
            lblNome1.Text = nomeCarta;
            lblCusto1.Text = custoCarta.ToString() + " Mana";
            lblTipo1.Text = tipoCarta;
            lblDescricao1.Text = descricaoCarta;
            lblStats1.Text = "Ataque/Defesa: " + ataqueCriatura + "/" + defesaCriatura;
            panel1.BackColor = corCarta;
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            btnIniciar.Visible = false;
            btnGerar.Visible = true;
            btnLutar.Visible = true;
            panel1.Visible = true;
            panel2.Visible = true;
            panel3.Visible = true;
            panel4.Visible = true;
            VidaInicialJogadores(ref vida1, ref vida2);
        }

        public void ExibeCarta2NaoCriatura(string tipoCarta, string nomeCarta, Color corCarta, string descricaoCarta, int custoCarta)
        {
            lblStats2.Visible = false;
            lblNome2.Text = nomeCarta;
            lblCusto2.Text = custoCarta.ToString() + " Mana";
            lblTipo2.Text = tipoCarta;
            lblDescricao2.Text = descricaoCarta;
            panel2.BackColor = corCarta;
        }

        public void ExibeCarta2Criatura(string tipoCarta, string nomeCarta, Color corCarta, string descricaoCarta, int custoCarta, int ataqueCriatura, int defesaCriatura)
        {
            lblStats2.Visible = true;
            lblNome2.Text = nomeCarta;
            lblCusto2.Text = custoCarta.ToString() + " Mana";
            lblTipo2.Text = tipoCarta;
            lblDescricao2.Text = descricaoCarta;
            lblStats2.Text = "Ataque/Defesa: " + ataqueCriatura + "/" + defesaCriatura;
            panel2.BackColor = corCarta;
        }

        public void VidaInicialJogadores(ref int vida1, ref int vida2)
        {
            vida1 = 20;
            vida2 = 20;

            lblJogador1.Text = "Jogador 1";
            lblJogador2.Text = "Jogador 2";
            lblVida1.Text = $"{vida1} HP";
            lblVida2.Text = $"{vida2} HP";
        }

        public void AtualizarVidaJogadores(int vida1, int vida2)
        {
            if (vida1 >= 0 && vida2 >= 0)
            {
                lblVida1.Text = $"{vida1} HP";
                lblVida2.Text = $"{vida2} HP";
            }
            else
            {
                if (vida1 < 0)
                {
                    lblVida1.Text = $"0 HP";
                    lblVida2.Text = $"{vida2} HP";
                }
                else
                {
                    lblVida1.Text = $"{vida1} HP";
                    lblVida2.Text = $"0 HP";
                }
            }
        }

        public void FinalizarJogo(ref int vida1, ref int vida2)
        {
            DialogResult resposta;

            if (vida1 <= 0)
            {
                resposta = MessageBox.Show($"Jogador 2 ganhou!", "Vencedor", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (resposta == DialogResult.OK)
                {
                    LimparForm();
                    vida1 = 1;
                }
            }
            else if (vida2 <= 0)
            {
                resposta = MessageBox.Show($"Jogador 1 ganhou!", "Vencedor", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (resposta == DialogResult.OK)
                {
                    LimparForm();
                    vida2 = 1;
                }
            }
        }

        public void LimparForm()
        {
            btnIniciar.Visible = true;
            btnGerar.Visible = false;
            btnLutar.Visible = false;
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            LimparCartas();
            acaoEfeito1 = 0;
            acaoEfeito2 = 0;
            acaoHabilidade1 = 0;
            acaoHabilidade2 = 0;
            ataque1 = 0;
            ataque2 = 0;
        }

        public void LimparCartas()
        {
            panel1.BackColor = Color.FromName("White");
            lblNome1.Text = string.Empty;
            lblCusto1.Text = string.Empty;
            lblTipo1.Text = string.Empty;
            lblDescricao1.Text = string.Empty;
            lblStats1.Text = string.Empty;

            panel2.BackColor = Color.FromName("White");
            lblNome2.Text = string.Empty;
            lblCusto2.Text = string.Empty;
            lblTipo2.Text = string.Empty;
            lblDescricao2.Text = string.Empty;
            lblStats2.Text = string.Empty;
        }
    }
}
