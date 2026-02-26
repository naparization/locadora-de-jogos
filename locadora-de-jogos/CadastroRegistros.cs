using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GerenciamentoDeFuncionarios.Modelo;
using GerenciamentoDeJogos.Modelo;
using GerenciamentoDeRegistros.Modelo;
using locadora_de_jogos.Modelo;
using locadora_de_jogos.Repositores;
using Timer = System.Windows.Forms.Timer;

namespace locadora_de_jogos
{
    public partial class CadastroRegistros : Form
    {
        public int idCliente;
        public bool usuarioOK;
        public bool jogoOK;
        private Timer frameTimer;
        public int idJogo;
        private readonly TelaInicial telaInicial;
        public Cliente clienteGlobal;
        public Registro registroGlobal;
        public Jogo jogoGlobal;
        public string nomeCliente;
        public string nomeJogo;
        public CadastroRegistros(TelaInicial telaInicial)
        {
            this.telaInicial = telaInicial;
            this.registroGlobal = new Registro();
            this.jogoOK = false;
            this.usuarioOK = false;
            this.jogoGlobal = new Jogo();


            InitializeComponent();
            IniciarTimer();


        }

        private void IniciarTimer()
        {
            frameTimer = new Timer();
            frameTimer.Interval = 60;
            frameTimer.Tick += FazerValidacao;
            frameTimer.Start();
        }

        private void FazerValidacao(object? sender, EventArgs e)
        {
            if (jogoOK == true && usuarioOK == true)
            {
                btnSalvar.Enabled = true;
            } else
            {
                btnSalvar.Enabled = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void btnSalvar_Click(object sender, EventArgs e)
        {
            DateTime dataDoRegistro = dtDataRegistro.Value;
            registroGlobal.NomeDoUsuario = txtIdUsuario.Text;
            registroGlobal.NomeDoJogo = txtIdJogo.Text;
            registroGlobal.DataAluguel = dataDoRegistro;
            int idDoJogo = int.Parse(txtIdJogo.Text);
            jogoGlobal = await JogoRepository.BuscarPorId(idDoJogo);
            switch (jogoGlobal.Categoria)
            {
                case CategoriaJogo.Bronze:
                    registroGlobal.DataDevolucao = dataDoRegistro.AddDays(30);
                    break;
                case CategoriaJogo.Prata:
                    registroGlobal.DataDevolucao = dataDoRegistro.AddDays(14);
                    break;
                case CategoriaJogo.Ouro:
                    registroGlobal.DataDevolucao = dataDoRegistro.AddDays(7);
                    break;
                default:
                    MessageBox.Show("Algo deu errado.");
                    break;
            }
            string dataParaDevolver = registroGlobal.DataDevolucao.ToString();
            await RegistroRepository.Adicionar(registroGlobal);
            await telaInicial.AtualizarTabela();
            MessageBox.Show($"Jogo {nomeJogo} alugado manualmente para cliente {nomeCliente}. Ele deve ser devolvido até {dataParaDevolver}", "Registro Concluído", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private async void txtIdUsuario_TextChanged(object sender, EventArgs e)
        {
            int idUsuario;
            try
            {
                idUsuario = int.Parse(txtIdUsuario.Text);

            } catch (Exception)
            {
                idUsuario = 0;
                usuarioOK = false;
            }

            var nomeDoCliente = await ClienteRepository.BuscarPorId(idUsuario);

            if (nomeDoCliente != null && nomeDoCliente.Nome.Length > 0) 
            {
                txtNomeCliente.Text = $"Usuário: {nomeDoCliente.Nome}";
                nomeCliente = nomeDoCliente.Nome;
                usuarioOK = true;

            } else
            {
                txtNomeCliente.Text = "Usuário: Não definido";
                usuarioOK = false;
            }
            

            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void txtIdJogo_TextChanged(object sender, EventArgs e)
        {
            int idJogo;
            try
            {
                idJogo = int.Parse(txtIdJogo.Text);
            }
            catch (Exception)
            {
                idJogo = 0;
                jogoOK = false;
            }

            var nomeDoJogo = await JogoRepository.BuscarPorId(idJogo);

            if (nomeDoJogo != null && nomeDoJogo.Titulo.Length > 0)
            {
                txtNomeJogo.Text = $"Jogo: {nomeDoJogo.Titulo}";
                nomeJogo = nomeDoJogo.Titulo;
                jogoOK = true;
            } else
            {
                txtNomeJogo.Text = "Jogo: Não definido";
                jogoOK = false;
            }
        }
    }
}
