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
    public partial class AtualizarJogo : Form
    {
        private Jogo jogoEdicao;
        private readonly int idJogo;
        private readonly TelaInicial telaInicial;
        public AtualizarJogo(int idJogo, TelaInicial telaInicial)
        {
            InitializeComponent();

            this.idJogo = idJogo;
            this.telaInicial = telaInicial;

            Load += AtualizarJogo_Load;

            
            
        }

        private async void AtualizarJogo_Load(object? sender, EventArgs e)
        {
            this.jogoEdicao = await JogoRepository.BuscarPorId(this.idJogo);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }
    }
}
