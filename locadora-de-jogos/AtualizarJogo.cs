using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GerenciamentoDeGenero.Modelo;
using GerenciamentoDeJogos.Modelo;
using locadora_de_jogos.Repositores;
using Timer = System.Windows.Forms.Timer;

namespace locadora_de_jogos
{
    public partial class AtualizarJogo : Form
    {
        private Jogo jogoEdicao;
        private Timer timer;
        public Jogo jogoUniversal;
        
        private readonly int idJogo;
        private readonly TelaInicial telaInicial;
        public AtualizarJogo(int idJogo, TelaInicial telaInicial)
        {
            InitializeComponent();
            IniciarTimer();

            this.idJogo = idJogo;
            this.telaInicial = telaInicial;

            Load += AtualizarJogo_Load;



        }

        private void IniciarTimer()
        {
            timer = new Timer();
            timer.Interval = 60;
            timer.Tick += FazerValidacao;
            timer.Start();
        }

        private void FazerValidacao(object? sender, EventArgs e)
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

        private async void AtualizarJogo_Load(object? sender, EventArgs e)
        {
            this.jogoEdicao = await JogoRepository.BuscarPorId(this.idJogo);

            txtNomeJogo.Text = jogoEdicao.Titulo;
            txtPreco.Text = jogoEdicao.Preco.ToString();

            switch (jogoEdicao.Genero)
            {
                case GeneroJogo.RPG:
                    rbRPG.Checked = true;
                    break;
                case GeneroJogo.Acao:
                    rbAcao.Checked = true;
                    break;
                case GeneroJogo.Shooter:
                    rbShooter.Checked = true;
                    break;
                default:
                    //
                    break;
            }
            dtLancamento.Value = jogoEdicao.DataLancamento;


            jogoUniversal = this.jogoEdicao;
            jogoUniversal.Id = this.jogoEdicao.Id;


        }

        private async void btnSalvar_Click(object sender, EventArgs e)
        {
            jogoUniversal.Id = jogoEdicao.Id;
            await JogoRepository.AtualizarPorId(jogoUniversal);
            await telaInicial.AtualizarTabela();
            this.Close();
        } 

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
