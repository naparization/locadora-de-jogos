using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GerenciamentoDeFuncionarios.Modelo;
using GerenciamentoDeGenero.Modelo;
using GerenciamentoDeJogos.Modelo;
using locadora_de_jogos.Repositores;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using Timer = System.Windows.Forms.Timer;

namespace locadora_de_jogos
{
    public partial class CadastroJogo : Form
    {
        private Timer frameTimer;
        public Jogo jogoUniversal;
        private readonly TelaInicial telaInicial;

        public CadastroJogo(TelaInicial telaInicial)
        {

            InitializeComponent();
            IniciarTimer();

            this.telaInicial = telaInicial;
        }

        private void IniciarTimer()
        {
            frameTimer = new Timer();
            frameTimer.Interval = 60;
            frameTimer.Tick += FazerValidacao;
            frameTimer.Start();
        }

        private void FazerValidacao(object sender, EventArgs e)
        {
            var jogo = new Jogo();

            jogo.Genero = rbAcao.Checked ? GeneroJogo.Acao : rbRPG.Checked ? GeneroJogo.RPG : GeneroJogo.Shooter;
            jogo.DataLancamento = dtLancamento.Value;
            jogo.Titulo = txtNomeJogo.Text;

            var stringBuilder = new StringBuilder();

            var listaDeErros = new List<ValidationResult>();

            var contexto = new ValidationContext(jogo);
            Validator.TryValidateObject(jogo, contexto, listaDeErros, true);
            try
            {
                jogo.Preco = decimal.Parse(txtPreco.Text);
            }
            catch (Exception)
            {
                listaDeErros.Add(new ValidationResult("Insira apenas valores númericos para o salário"));
            }


            if (listaDeErros.Count > 0)
            {
                foreach (var erro in listaDeErros)
                {
                    stringBuilder.Append(erro.ErrorMessage + "\n");
                    btnSalvar.Enabled = false;
                    txtErro.Text = stringBuilder.ToString();
                }
            }
            else
            {
                txtErro.Text = "";
                btnSalvar.Enabled = true;
            }

            jogoUniversal = jogo;

        }

        private async Task button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnSalvar_MouseHover(object sender, EventArgs e)
        {
            string Erro = " ";
            txtErro.Text = Erro;

            if (txtNomeJogo.Text.Length < 1)
            {
                Erro = Erro + "Campo \"Nome\" é obrigatório. \n";
                txtErro.Text = Erro;
            }
        }

        private async void btnSalvar_Click(object sender, EventArgs e)
        {
            JogoRepository.Adicionar(jogoUniversal);
            await telaInicial.AtualizarTabela();
            this.Close();
        }
    }
}
