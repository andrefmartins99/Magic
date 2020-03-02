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
        public List<Habilidade> Habilidades { get; }

        public List<Efeito> Efeitos { get; }

        public Terreno CartaTerreno { get; set; }

        public Feitico CartaFeitico { get; set; }

        public MagicaInstantanea CartaMagicaInstantanea { get; set; }

        public Encantamento CartaEncantamento { get; set; }

        public Elfo CartaCriaturaElfo { get; set; }

        public Humano CartaCriaturaHumano { get; set; }

        public Orc CartaCriaturaOrc { get; set; }

        public Anao CartaCriaturaAnao { get; set; }

        public int AcaoEfeito1 { get; set; }

        public int AcaoEfeito2 { get; set; }

        public int AcaoHabilidade1 { get; set; }

        public int AcaoHabilidade2 { get; set; }

        public int Ataque1 { get; set; }

        public int Ataque2 { get; set; }

        public int Vida1 { get; set; }

        public int Vida2 { get; set; }

        public Magic()
        {
            InitializeComponent();
            Habilidades = MetodosCartaHabilidade.PreencherListaHabilidades();
            Efeitos = MetodosCartaEfeito.PreencherListaEfeitos();
        }

        //Iniciar Jogo
        private void btnIniciar_Click(object sender, EventArgs e)
        {
            btnIniciar.Visible = false;
            btnGerar.Visible = true;
            btnLutar.Visible = true;
            panel1.Visible = true;
            panel2.Visible = true;
            panel3.Visible = true;
            panel4.Visible = true;
            VidaInicialJogadores();
        }

        //Gerar cartas
        private void btnGerar_Click(object sender, EventArgs e)
        {
            Random rng;
            int rnd;
            int numCarta = 1;
            NovoTurno();
            rng = GerarRandom(numCarta);

            do
            {
                rnd = rng.Next(1, 9);

                switch (rnd)
                {
                    case 1:
                        CriarCartaTerreno(numCarta);
                        ExibeTerreno(numCarta);
                        break;

                    case 2:
                        CriarCartaFeitico(numCarta);
                        ExibeFeitico(numCarta);
                        break;

                    case 3:
                        CriarCartaMagicaInstantanea(numCarta);
                        ExibeMagicaInstantanea(numCarta);
                        break;

                    case 4:
                        CriarCartaEncantamento(numCarta);
                        ExibeEncantamento(numCarta);
                        break;

                    case 5:
                        CriarCartaCriaturaElfo(numCarta);
                        ExibeCriaturaElfo(numCarta);
                        break;

                    case 6:
                        CriarCartaCriaturaHumano(numCarta);
                        ExibeCriaturaHumano(numCarta);
                        break;

                    case 7:
                        CriarCartaCriaturaOrc(numCarta);
                        ExibeCriaturaOrc(numCarta);
                        break;

                    case 8:
                        CriarCartaCriaturaAnao(numCarta);
                        ExibeCriaturaAnao(numCarta);
                        break;

                    default:
                        CriarCartaCriaturaHumano(numCarta);
                        ExibeCriaturaHumano(numCarta);
                        break;
                }

                numCarta++;

            } while (numCarta <= 2);

            btnGerar.Enabled = false;
            btnLutar.Enabled = true;
        }

        //Luta
        private void btnLutar_Click(object sender, EventArgs e)
        {
            if (AcaoEfeito1 > 0 && AcaoEfeito2 > 0)
            {
                Vida1 += AcaoEfeito1;
                Vida2 += AcaoEfeito2;

                AtualizarVidaJogadores();
            }
            else if (AcaoEfeito1 > 0)
            {
                Vida1 += AcaoEfeito1;
                AtualizarVidaJogadores();

                Vida1 += AcaoHabilidade2;
                AtualizarVidaJogadores();
                FinalizarJogo();

                Vida1 -= Ataque2;
                AtualizarVidaJogadores();
                FinalizarJogo();
            }
            else if (AcaoEfeito2 > 0)
            {
                Vida2 += AcaoEfeito2;

                Vida2 += AcaoHabilidade1;
                AtualizarVidaJogadores();
                FinalizarJogo();

                Vida2 -= Ataque1;
                AtualizarVidaJogadores();
                FinalizarJogo();
            }
            else
            {
                Vida1 += AcaoEfeito2;
                AtualizarVidaJogadores();
                FinalizarJogo();
                Vida2 += AcaoEfeito1;
                AtualizarVidaJogadores();
                FinalizarJogo();

                Vida1 += AcaoHabilidade2;
                AtualizarVidaJogadores();
                FinalizarJogo();
                Vida2 += AcaoHabilidade1;
                AtualizarVidaJogadores();
                FinalizarJogo();

                if (Ataque1 > Ataque2)
                {
                    Vida2 -= (Ataque1 - Ataque2);
                    AtualizarVidaJogadores();
                    FinalizarJogo();
                }
                else if (Ataque1 < Ataque2)
                {
                    Vida1 -= (Ataque2 - Ataque1);
                    AtualizarVidaJogadores();
                    FinalizarJogo();
                }
            }

            btnGerar.Enabled = true;
            btnLutar.Enabled = false;
        }

        /// <summary>
        /// Criar carta do tipo Terreno
        /// </summary>
        /// <param name="numCarta">Número que corresponde ao nº da carta a ser criada (1º carta ou 2º carta)</param>
        public void CriarCartaTerreno(int numCarta)
        {
            Random rng;

            rng = GerarRandom(numCarta);

            int nome, cor, desc;

            nome = rng.Next(0, 2);
            cor = rng.Next(0, 5);
            desc = rng.Next(0, 3);

            CartaTerreno = new Terreno(nome, cor, desc, 0);
        }

        /// <summary>
        /// Criar carta do tipo Feitiço
        /// </summary>
        /// <param name="numCarta">Número que corresponde ao nº da carta a ser criada (1º carta ou 2º carta)</param>
        public void CriarCartaFeitico(int numCarta)
        {
            Random rng;

            rng = GerarRandom(numCarta);

            int cor, custo, efeito;

            cor = rng.Next(0, 5);
            custo = rng.Next(1, 6);
            efeito = rng.Next(0, 5);

            CartaFeitico = new Feitico(cor, custo, efeito, Efeitos);

            if (numCarta == 1)
            {
                AcaoEfeito1 = CartaFeitico.AcaoEfeito;
            }
            else
            {
                AcaoEfeito2 = CartaFeitico.AcaoEfeito;
            }
        }

        /// <summary>
        /// Criar carta do tipo Mágica Instantânea
        /// </summary>
        /// <param name="numCarta">Número que corresponde ao nº da carta a ser criada (1º carta ou 2º carta)</param>
        public void CriarCartaMagicaInstantanea(int numCarta)
        {
            Random rng;

            rng = GerarRandom(numCarta);

            int cor, custo, efeito;

            cor = rng.Next(0, 5);
            custo = rng.Next(1, 6);
            efeito = rng.Next(0, 5);

            CartaMagicaInstantanea = new MagicaInstantanea(cor, custo, efeito, Efeitos);

            if (numCarta == 1)
            {
                AcaoHabilidade1 = CartaMagicaInstantanea.AcaoEfeito;
            }
            else
            {
                AcaoHabilidade2 = CartaMagicaInstantanea.AcaoEfeito;
            }
        }

        /// <summary>
        /// Criar carta do tipo Encantamento
        /// </summary>
        /// <param name="numCarta">Número que corresponde ao nº da carta a ser criada (1º carta ou 2º carta)</param>
        public void CriarCartaEncantamento(int numCarta)
        {
            Random rng;

            rng = GerarRandom(numCarta);

            int cor, custo, numHabilidade, habilidade1, habilidade2;

            cor = rng.Next(0, 5);
            custo = rng.Next(1, 6);
            numHabilidade = rng.Next(0, 3);
            habilidade1 = rng.Next(0, 5);

            do
            {
                habilidade2 = rng.Next(0, 5);

            } while (habilidade2 == habilidade1);

            CartaEncantamento = new Encantamento(cor, custo, numHabilidade, habilidade1, habilidade2, Habilidades);

            if (numCarta == 1)
            {
                AcaoHabilidade1 = CartaEncantamento.AcaoHabilidade;
            }
            else
            {
                AcaoHabilidade2 = CartaEncantamento.AcaoHabilidade;
            }
        }

        /// <summary>
        /// Criar carta do tipo Criatura/Elfo
        /// </summary>
        /// <param name="numCarta">Número que corresponde ao nº da carta a ser criada (1º carta ou 2º carta)</param>
        public void CriarCartaCriaturaElfo(int numCarta)
        {
            Random rng;

            rng = GerarRandom(numCarta);

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

            CartaCriaturaElfo = new Elfo(cor, custo, numHabilidade, habilidade1, habilidade2, descricao, ataque, defesa, Habilidades);

            if (numCarta == 1)
            {
                AcaoHabilidade1 = CartaCriaturaElfo.AcaoHabilidade;
                Ataque1 = CartaCriaturaElfo.AtaqueCriatura;
            }
            else
            {
                AcaoHabilidade2 = CartaCriaturaElfo.AcaoHabilidade;
                Ataque2 = CartaCriaturaElfo.AtaqueCriatura;
            }
        }

        /// <summary>
        /// Criar carta do tipo Criatura/Humano
        /// </summary>
        /// <param name="numCarta">Número que corresponde ao nº da carta a ser criada (1º carta ou 2º carta)</param>
        public void CriarCartaCriaturaHumano(int numCarta)
        {
            Random rng;

            rng = GerarRandom(numCarta);

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

            CartaCriaturaHumano = new Humano(cor, custo, numHabilidade, habilidade1, habilidade2, descricao, ataque, defesa, Habilidades);

            if (numCarta == 1)
            {
                AcaoHabilidade1 = CartaCriaturaHumano.AcaoHabilidade;
                Ataque1 = CartaCriaturaHumano.AtaqueCriatura;
            }
            else
            {
                AcaoHabilidade2 = CartaCriaturaHumano.AcaoHabilidade;
                Ataque2 = CartaCriaturaHumano.AtaqueCriatura;
            }
        }

        /// <summary>
        /// Criar carta do tipo Criatura/Orc
        /// </summary>
        /// <param name="numCarta">Número que corresponde ao nº da carta a ser criada (1º carta ou 2º carta)</param>
        public void CriarCartaCriaturaOrc(int numCarta)
        {
            Random rng;

            rng = GerarRandom(numCarta);

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

            CartaCriaturaOrc = new Orc(cor, custo, numHabilidade, habilidade1, habilidade2, descricao, ataque, defesa, Habilidades);

            if (numCarta == 1)
            {
                AcaoHabilidade1 = CartaCriaturaOrc.AcaoHabilidade;
                Ataque1 = CartaCriaturaOrc.AtaqueCriatura;
            }
            else
            {
                AcaoHabilidade2 = CartaCriaturaOrc.AcaoHabilidade;
                Ataque2 = CartaCriaturaOrc.AtaqueCriatura;
            }
        }

        /// <summary>
        /// Criar carta do tipo Criatura/Anão
        /// </summary>
        /// <param name="numCarta">Número que corresponde ao nº da carta a ser criada (1º carta ou 2º carta)</param>
        public void CriarCartaCriaturaAnao(int numCarta)
        {
            Random rng;

            rng = GerarRandom(numCarta);

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

            CartaCriaturaAnao = new Anao(cor, custo, numHabilidade, habilidade1, habilidade2, descricao, ataque, defesa, Habilidades);

            if (numCarta == 1)
            {
                AcaoHabilidade1 = CartaCriaturaAnao.AcaoHabilidade;
                Ataque1 = CartaCriaturaAnao.AtaqueCriatura;
            }
            else
            {
                AcaoHabilidade2 = CartaCriaturaAnao.AcaoHabilidade;
                Ataque2 = CartaCriaturaAnao.AtaqueCriatura;
            }
        }

        /// <summary>
        /// Passar para variáveis as informações da carta Terreno
        /// </summary>
        /// <param name="numCarta">Número que corresponde ao nº da carta a ser criada (1º carta ou 2º carta)</param>
        public void ExibeTerreno(int numCarta)
        {
            string tipoCarta, nomeCarta, descricaoCarta;
            int custoCarta;
            Color corCarta;

            tipoCarta = CartaTerreno.TipoCarta;
            nomeCarta = CartaTerreno.NomeCarta;
            corCarta = CartaTerreno.CorCarta;
            custoCarta = CartaTerreno.CustoCarta;
            descricaoCarta = CartaTerreno.DescricaoCarta;

            if (numCarta == 1)
            {
                //Passar as variáveis com as informações da carta para o template 1
                ExibeCarta1NaoCriatura(tipoCarta, nomeCarta, corCarta, descricaoCarta, custoCarta);
            }
            else
            {
                //Passar as variáveis com as informações da carta para o template 2
                ExibeCarta2NaoCriatura(tipoCarta, nomeCarta, corCarta, descricaoCarta, custoCarta);
            }
        }

        /// <summary>
        /// Passar para variáveis as informações da carta Feitiço
        /// </summary>
        /// <param name="numCarta">Número que corresponde ao nº da carta a ser criada (1º carta ou 2º carta)</param>
        public void ExibeFeitico(int numCarta)
        {
            string tipoCarta, nomeCarta, descricaoCarta;
            int custoCarta;
            Color corCarta;

            tipoCarta = CartaFeitico.TipoCarta;
            nomeCarta = CartaFeitico.NomeCarta;
            corCarta = CartaFeitico.CorCarta;
            custoCarta = CartaFeitico.CustoCarta;
            descricaoCarta = CartaFeitico.DescricaoCarta;

            if (numCarta == 1)
            {
                //Passar as variáveis com as informações da carta para o template 1
                ExibeCarta1NaoCriatura(tipoCarta, nomeCarta, corCarta, descricaoCarta, custoCarta);
            }
            else
            {
                //Passar as variáveis com as informações da carta para o template 2
                ExibeCarta2NaoCriatura(tipoCarta, nomeCarta, corCarta, descricaoCarta, custoCarta);
            }
        }

        /// <summary>
        /// Passar para variáveis as informações da carta Mágica Instantânea
        /// </summary>
        /// <param name="numCarta">Número que corresponde ao nº da carta a ser criada (1º carta ou 2º carta)</param>
        public void ExibeMagicaInstantanea(int numCarta)
        {
            string tipoCarta, nomeCarta, descricaoCarta;
            int custoCarta;
            Color corCarta;

            tipoCarta = CartaMagicaInstantanea.TipoCarta;
            nomeCarta = CartaMagicaInstantanea.NomeCarta;
            corCarta = CartaMagicaInstantanea.CorCarta;
            custoCarta = CartaMagicaInstantanea.CustoCarta;
            descricaoCarta = CartaMagicaInstantanea.DescricaoCarta;

            if (numCarta == 1)
            {
                //Passar as variáveis com as informações da carta para o template 1
                ExibeCarta1NaoCriatura(tipoCarta, nomeCarta, corCarta, descricaoCarta, custoCarta);
            }
            else
            {
                //Passar as variáveis com as informações da carta para o template 2
                ExibeCarta2NaoCriatura(tipoCarta, nomeCarta, corCarta, descricaoCarta, custoCarta);
            }
        }

        /// <summary>
        /// Passar para variáveis as informações da carta Encantamento
        /// </summary>
        /// <param name="numCarta">Número que corresponde ao nº da carta a ser criada (1º carta ou 2º carta)</param>
        public void ExibeEncantamento(int numCarta)
        {
            string tipoCarta, nomeCarta, descricaoCarta;
            int custoCarta;
            Color corCarta;

            tipoCarta = CartaEncantamento.TipoCarta;
            nomeCarta = CartaEncantamento.NomeCarta;
            corCarta = CartaEncantamento.CorCarta;
            custoCarta = CartaEncantamento.CustoCarta;
            descricaoCarta = CartaEncantamento.DescricaoCarta;

            if (numCarta == 1)
            {
                //Passar as variáveis com as informações da carta para o template 1
                ExibeCarta1NaoCriatura(tipoCarta, nomeCarta, corCarta, descricaoCarta, custoCarta);
            }
            else
            {
                //Passar as variáveis com as informações da carta para o template 2
                ExibeCarta2NaoCriatura(tipoCarta, nomeCarta, corCarta, descricaoCarta, custoCarta);
            }
        }

        /// <summary>
        /// Passar para variáveis as informações da carta Criatuta/Elfo
        /// </summary>
        /// <param name="numCarta">Número que corresponde ao nº da carta a ser criada (1º carta ou 2º carta)</param>
        public void ExibeCriaturaElfo(int numCarta)
        {
            string tipoCarta, nomeCarta, descricaoCarta;
            int custoCarta, ataqueCriatura, defesaCriatura;
            Color corCarta;

            tipoCarta = CartaCriaturaElfo.TipoCarta;
            nomeCarta = CartaCriaturaElfo.NomeCarta;
            corCarta = CartaCriaturaElfo.CorCarta;
            custoCarta = CartaCriaturaElfo.CustoCarta;
            descricaoCarta = CartaCriaturaElfo.DescricaoCarta;
            ataqueCriatura = CartaCriaturaElfo.AtaqueCriatura;
            defesaCriatura = CartaCriaturaElfo.DefesaCriatura;

            if (numCarta == 1)
            {
                //Passar as variáveis com as informações da carta para o template 1
                ExibeCarta1Criatura(tipoCarta, nomeCarta, corCarta, descricaoCarta, custoCarta, ataqueCriatura, defesaCriatura);
            }
            else
            {
                //Passar as variáveis com as informações da carta para o template 2
                ExibeCarta2Criatura(tipoCarta, nomeCarta, corCarta, descricaoCarta, custoCarta, ataqueCriatura, defesaCriatura);
            }
        }

        /// <summary>
        /// Passar para variáveis as informações da carta Criatuta/Humano
        /// </summary>
        /// <param name="numCarta">Número que corresponde ao nº da carta a ser criada (1º carta ou 2º carta)</param>
        public void ExibeCriaturaHumano(int numCarta)
        {
            string tipoCarta, nomeCarta, descricaoCarta;
            int custoCarta, ataqueCriatura, defesaCriatura;
            Color corCarta;

            tipoCarta = CartaCriaturaHumano.TipoCarta;
            nomeCarta = CartaCriaturaHumano.NomeCarta;
            corCarta = CartaCriaturaHumano.CorCarta;
            custoCarta = CartaCriaturaHumano.CustoCarta;
            descricaoCarta = CartaCriaturaHumano.DescricaoCarta;
            ataqueCriatura = CartaCriaturaHumano.AtaqueCriatura;
            defesaCriatura = CartaCriaturaHumano.DefesaCriatura;

            if (numCarta == 1)
            {
                //Passar as variáveis com as informações da carta para o template 1
                ExibeCarta1Criatura(tipoCarta, nomeCarta, corCarta, descricaoCarta, custoCarta, ataqueCriatura, defesaCriatura);
            }
            else
            {
                //Passar as variáveis com as informações da carta para o template 2
                ExibeCarta2Criatura(tipoCarta, nomeCarta, corCarta, descricaoCarta, custoCarta, ataqueCriatura, defesaCriatura);
            }
        }

        /// <summary>
        /// Passar para variáveis as informações da carta Criatuta/Orc
        /// </summary>
        /// <param name="numCarta">Número que corresponde ao nº da carta a ser criada (1º carta ou 2º carta)</param>
        public void ExibeCriaturaOrc(int numCarta)
        {
            string tipoCarta, nomeCarta, descricaoCarta;
            int custoCarta, ataqueCriatura, defesaCriatura;
            Color corCarta;

            tipoCarta = CartaCriaturaOrc.TipoCarta;
            nomeCarta = CartaCriaturaOrc.NomeCarta;
            corCarta = CartaCriaturaOrc.CorCarta;
            custoCarta = CartaCriaturaOrc.CustoCarta;
            descricaoCarta = CartaCriaturaOrc.DescricaoCarta;
            ataqueCriatura = CartaCriaturaOrc.AtaqueCriatura;
            defesaCriatura = CartaCriaturaOrc.DefesaCriatura;

            if (numCarta == 1)
            {
                //Passar as variáveis com as informações da carta para o template 1
                ExibeCarta1Criatura(tipoCarta, nomeCarta, corCarta, descricaoCarta, custoCarta, ataqueCriatura, defesaCriatura);
            }
            else
            {
                //Passar as variáveis com as informações da carta para o template 2
                ExibeCarta2Criatura(tipoCarta, nomeCarta, corCarta, descricaoCarta, custoCarta, ataqueCriatura, defesaCriatura);
            }
        }

        /// <summary>
        /// Passar para variáveis as informações da carta Criatuta/Anão
        /// </summary>
        /// <param name="numCarta">Número que corresponde ao nº da carta a ser criada (1º carta ou 2º carta)</param>
        public void ExibeCriaturaAnao(int numCarta)
        {
            string tipoCarta, nomeCarta, descricaoCarta;
            int custoCarta, ataqueCriatura, defesaCriatura;
            Color corCarta;

            tipoCarta = CartaCriaturaAnao.TipoCarta;
            nomeCarta = CartaCriaturaAnao.NomeCarta;
            corCarta = CartaCriaturaAnao.CorCarta;
            custoCarta = CartaCriaturaAnao.CustoCarta;
            descricaoCarta = CartaCriaturaAnao.DescricaoCarta;
            ataqueCriatura = CartaCriaturaAnao.AtaqueCriatura;
            defesaCriatura = CartaCriaturaAnao.DefesaCriatura;

            if (numCarta == 1)
            {
                //Passar as variáveis com as informações da carta para o template 1
                ExibeCarta1Criatura(tipoCarta, nomeCarta, corCarta, descricaoCarta, custoCarta, ataqueCriatura, defesaCriatura);
            }
            else
            {
                //Passar as variáveis com as informações da carta para o template 2
                ExibeCarta2Criatura(tipoCarta, nomeCarta, corCarta, descricaoCarta, custoCarta, ataqueCriatura, defesaCriatura);
            }
        }

        /// <summary>
        /// Passar as variáveis com a informação da carta não criatura para o template 1
        /// </summary>
        /// <param name="tipoCarta">Tipo da carta</param>
        /// <param name="nomeCarta">Nome da carta</param>
        /// <param name="corCarta">Cor da carta</param>
        /// <param name="descricaoCarta">Descrição da carta</param>
        /// <param name="custoCarta">Custo da carta</param>
        public void ExibeCarta1NaoCriatura(string tipoCarta, string nomeCarta, Color corCarta, string descricaoCarta, int custoCarta)
        {
            lblStats1.Visible = false;
            lblNome1.Text = nomeCarta;
            lblCusto1.Text = custoCarta.ToString() + " Mana";
            lblTipo1.Text = tipoCarta;
            lblDescricao1.Text = descricaoCarta;
            panel1.BackColor = corCarta;
        }

        /// <summary>
        /// Passar as variáveis com a informação da carta criatura para o template 1
        /// </summary>
        /// <param name="tipoCarta">Tipo da carta</param>
        /// <param name="nomeCarta">Nome da carta</param>
        /// <param name="corCarta">Cor da carta</param>
        /// <param name="descricaoCarta">Descrição da carta</param>
        /// <param name="custoCarta">Custo da carta</param>
        /// <param name="ataqueCriatura">Ataque da criatura</param>
        /// <param name="defesaCriatura">Defesa da criatura</param>
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

        /// <summary>
        /// Passar as variáveis com a informação da carta não criatura para o template 2
        /// </summary>
        /// <param name="tipoCarta">Tipo da carta</param>
        /// <param name="nomeCarta">Nome da carta</param>
        /// <param name="corCarta">Cor da carta</param>
        /// <param name="descricaoCarta">Descrição da carta</param>
        /// <param name="custoCarta">Custo da carta</param>
        public void ExibeCarta2NaoCriatura(string tipoCarta, string nomeCarta, Color corCarta, string descricaoCarta, int custoCarta)
        {
            lblStats2.Visible = false;
            lblNome2.Text = nomeCarta;
            lblCusto2.Text = custoCarta.ToString() + " Mana";
            lblTipo2.Text = tipoCarta;
            lblDescricao2.Text = descricaoCarta;
            panel2.BackColor = corCarta;
        }

        /// <summary>
        /// Passar as variáveis com a informação da carta criatura para o template 2
        /// </summary>
        /// <param name="tipoCarta">Tipo da carta</param>
        /// <param name="nomeCarta">Nome da carta</param>
        /// <param name="corCarta">Cor da carta</param>
        /// <param name="descricaoCarta">Descrição da carta</param>
        /// <param name="custoCarta">Custo da carta</param>
        /// <param name="ataqueCriatura">Ataque da criatura</param>
        /// <param name="defesaCriatura">Defesa da criatura</param>
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

        /// <summary>
        /// Definir a vida inicial dos 2 jogadores e apresentá-la
        /// </summary>
        public void VidaInicialJogadores()
        {
            Vida1 = 20;
            Vida2 = 20;

            lblJogador1.Text = "Jogador 1";
            lblJogador2.Text = "Jogador 2";
            lblVida1.Text = $"{Vida1} HP";
            lblVida2.Text = $"{Vida2} HP";
        }

        /// <summary>
        /// Atualizar as labels com a vida dos jogadores, após luta
        /// </summary>
        public void AtualizarVidaJogadores()
        {
            if (Vida1 >= 0 && Vida2 >= 0)
            {
                lblVida1.Text = $"{Vida1} HP";
                lblVida2.Text = $"{Vida2} HP";
            }
            else
            {
                if (Vida1 < 0)
                {
                    lblVida1.Text = $"0 HP";
                    lblVida2.Text = $"{Vida2} HP";
                }
                else
                {
                    lblVida1.Text = $"{Vida1} HP";
                    lblVida2.Text = $"0 HP";
                }
            }
        }

        /// <summary>
        /// Finalizar o jogo quando a vida de um dos jogadores chega a 0
        /// </summary>
        public void FinalizarJogo()
        {
            DialogResult resposta;

            if (Vida1 <= 0)
            {
                resposta = MessageBox.Show($"Jogador 2 ganhou!", "Vencedor", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (resposta == DialogResult.OK)
                {
                    LimparForm();
                    Vida1 = 1;
                }
            }
            else if (Vida2 <= 0)
            {
                resposta = MessageBox.Show($"Jogador 1 ganhou!", "Vencedor", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (resposta == DialogResult.OK)
                {
                    LimparForm();
                    Vida2 = 1;
                }
            }
        }

        /// <summary>
        /// Limpar o form, para se poder iniciar novo jogo
        /// </summary>
        public void LimparForm()
        {
            LimparCartas();
            btnIniciar.Visible = true;
            btnGerar.Visible = false;
            btnLutar.Visible = false;
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            AcaoEfeito1 = 0;
            AcaoEfeito2 = 0;
            AcaoHabilidade1 = 0;
            AcaoHabilidade2 = 0;
            Ataque1 = 0;
            Ataque2 = 0;
        }

        /// <summary>
        /// Limpar os templates das cartas
        /// </summary>
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

        /// <summary>
        /// Gerar random, com uma seed que depende do número da carta a ser criada (1º carta ou 2º carta)
        /// </summary>
        /// <param name="numCarta"></param>
        /// <returns></returns>
        public Random GerarRandom(int numCarta)
        {
            Random rng;

            if (numCarta == 1)
            {
                Random random = new Random();
                rng = new Random(random.Next(0, 1000001));
            }
            else
            {
                Random random = new Random();
                rng = new Random(random.Next(1000002, 2000001));
            }

            return rng;
        }

        /// <summary>
        /// Preparar para o novo turno do jogo
        /// </summary>
        public void NovoTurno()
        {
            AcaoEfeito1 = 0;
            AcaoEfeito2 = 0;
            AcaoHabilidade1 = 0;
            AcaoHabilidade2 = 0;
            Ataque1 = 0;
            Ataque2 = 0;
            CartaTerreno = null;
            CartaFeitico = null;
            CartaMagicaInstantanea = null;
            CartaEncantamento = null;
            CartaCriaturaElfo = null;
            CartaCriaturaHumano = null;
            CartaCriaturaOrc = null;
            CartaCriaturaAnao = null;
        }

        //Créditos
        private void btnCreditos_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Feito por André Martins{Environment.NewLine}Versão 1.3{Environment.NewLine}Data: 01/03/2020", "Créditos", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
