using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GerenciamentoDeJogos.Modelo;
using GerenciamentoDeRegistros.Modelo;
using locadora_de_jogos.Modelo;
using locadora_de_jogos.Repositores;

namespace locadora_de_jogos
{

    public partial class AlugarJogo : Form
    {
        private int idJogo;
        private string idUsuario;
        public Registro registro;

        private TelaInicial telaInicial;

        public AlugarJogo(int idJogo, string idUsuario, TelaInicial telaInicial)
        {

            this.idJogo = idJogo;
            this.registro = new Registro();
            this.idUsuario = idUsuario;
            this.telaInicial = telaInicial;
            InitializeComponent();

            Load += AlugarJogo_Load;
        }

        private async void AlugarJogo_Load(object? sender, EventArgs e)
        {
            var nomeJogo = await JogoRepository.BuscarPorId(idJogo);
            txtNomeJogo.Text = $"Deseja alugar o jogo \n\"{nomeJogo.Titulo}\" ?";
            dtRetirarada.MinDate = DateTime.Now;
        }

        private async void btnSalvar_Click(object sender, EventArgs e)
        {
            
            DateTime dataRetirada = dtRetirarada.Value;
            DateTime dataDevolucao = dataRetirada;
            var nomeJogo = await JogoRepository.BuscarPorId(idJogo);
            switch (nomeJogo.Categoria)
            {
                case CategoriaJogo.Bronze:
                    dataDevolucao = dataRetirada.AddDays(30);
                    break;
                case CategoriaJogo.Prata:
                    dataDevolucao = dataRetirada.AddDays(14);
                    break;
                case CategoriaJogo.Ouro:
                    dataDevolucao = dataRetirada.AddDays(7);
                    break;
                default:
                    //
                    break;
            }
            var disponibilidade = await RegistroRepository.VerificarDisponibilidade(idJogo, dataRetirada, dataDevolucao);
            if (disponibilidade == null)
            {
                registro.NomeDoJogo = idJogo.ToString();
                var cliente = await ClienteRepository.BuscarPorIdentificador(idUsuario);
                registro.NomeDoUsuario = cliente.Id.ToString();
                registro.DataAluguel = dataRetirada;
                registro.DataDevolucao = dataDevolucao;
                await RegistroRepository.Adicionar(registro);
                MessageBox.Show($"Jogo {nomeJogo.Titulo} alugado com sucesso. \nVocê tem até {dataDevolucao} para devolver.");
                this.Close();



            }
            else
            {
                MessageBox.Show($"Esta data está indisponível, tente uma data futura.");
            }
        }

        private void dtRetirarada_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
