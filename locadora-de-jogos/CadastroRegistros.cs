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
        public CadastroRegistros(TelaInicial telaInicial)
        {
            this.telaInicial = telaInicial;

            InitializeComponent();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async Task btnSalvar_Click(object sender, EventArgs e)
        {
            DateTime dataHoje = DateTime.Now;
            registroGlobal.NomeDoUsuario = txtIdUsuario.Text;
            registroGlobal.NomeDoJogo = txtIdJogo.Text;
            registroGlobal.DataAluguel = dataHoje;
            registroGlobal.DataDevolucao = dataHoje.AddDays(30);
            await RegistroRepository.Adicionar(registroGlobal);
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
                } else
                {
                    txtNomeCliente.Text = "Usuário: " + clienteNome.Nome.ToString();
                    btnSalvar.Enabled = true;
                }

                
                    

            } catch (Exception) {
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
                    btnSalvar.Enabled = true;
                }
            } catch (Exception)
            {
                btnSalvar.Enabled = false;
            }

            if (txtNomeJogo == null || txtNomeCliente == null)
            {
                btnSalvar.Enabled = false;
            }
            
            
        }
    }
}
