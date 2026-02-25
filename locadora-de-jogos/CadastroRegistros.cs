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
using GerenciamentoDeRegistros.Modelo;
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
        public string nomeCliente;
        public string nomeJogo;
        public CadastroRegistros(TelaInicial telaInicial)
        {
            this.telaInicial = telaInicial;
            this.registroGlobal = new Registro();
            

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
            registroGlobal.DataDevolucao = dataDoRegistro.AddDays(30);
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
                    btnSalvar.Enabled = false;
                }
                else
                {
                    txtNomeCliente.Text = "Usuário: " + clienteNome.Nome.ToString();
                    nomeCliente = clienteNome.Nome.ToString();
                    btnSalvar.Enabled = true;
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
                    btnSalvar.Enabled = false;
                }
                else
                {
                    txtNomeJogo.Text = "Jogo: " + jogoNome.Titulo.ToString();
                    nomeJogo = jogoNome.Titulo.ToString();
                    btnSalvar.Enabled = true;
                }
            }
            catch (Exception)
            {
                btnSalvar.Enabled = false;
            }

            if (txtNomeJogo == null || txtNomeCliente == null)
            {
                btnSalvar.Enabled = false;
            }


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
