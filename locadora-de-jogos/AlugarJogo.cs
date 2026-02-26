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
using locadora_de_jogos.Repositores;

namespace locadora_de_jogos
{
   
    public partial class AlugarJogo : Form
    {
        private int idJogo;
        private TelaInicial telaInicial;

        public AlugarJogo(int idJogo, TelaInicial telaInicial)
        {
            
            this.idJogo = idJogo;
            this.telaInicial = telaInicial;
            InitializeComponent();

            Load += AlugarJogo_Load;
        }

        private async void AlugarJogo_Load(object? sender, EventArgs e)
        {
            var nomeJogo = await JogoRepository.BuscarPorId(idJogo); 
            txtNomeJogo.Text = $"Deseja alugar o jogo \"{nomeJogo.Titulo}\" ?";
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }
    }
}
