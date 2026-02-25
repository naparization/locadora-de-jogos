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

namespace locadora_de_jogos
{
    public partial class CadastroRegistros : Form
    {
        public int idCliente;
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
            this.jogoGlobal = new Jogo();
            

            InitializeComponent();


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
            try
            {
                idCliente = int.Parse(txtIdUsuario.Text);

                var clienteNome = await ClienteRepository.BuscarPorId(idCliente);

                if (clienteNome == null)
                {
                    txtNomeCliente.Text = "Usuário: Não definido";
                    
                }
                else
                {
                    txtNomeCliente.Text = "Usuário: " + clienteNome.Nome.ToString();
                    nomeCliente = clienteNome.Nome.ToString();
                    
                }




            }
            catch (Exception)
            {
                btnSalvar.Enabled = false;
            }

            try
            {
                idJogo = int.Parse(txtIdJogo.Text);
                var jogoNome = await JogoRepository.BuscarPorId(idJogo);
                if (jogoNome == null)
                {
                    txtNomeJogo.Text = "Jogo: Não definido";
                    
                }
                else
                {
                    txtNomeJogo.Text = "Jogo: " + jogoNome.Titulo.ToString();
                    nomeJogo = jogoNome.Titulo.ToString();
                    
                }
            }
            catch (Exception)
            {
                btnSalvar.Enabled = false;
            }

            if (txtNomeJogo.Text.Length < 1 || txtNomeCliente.Text.Length < 1)
            {
                btnSalvar.Enabled = false;
            } else
            {
                btnSalvar.Enabled = true;
            }


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
