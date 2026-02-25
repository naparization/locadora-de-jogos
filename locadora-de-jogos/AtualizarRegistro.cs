using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GerenciamentoDeRegistros.Modelo;
using locadora_de_jogos.Repositores;

namespace locadora_de_jogos
{
    public partial class AtualizarRegistro : Form
    {
        public Registro registroGlobal;
        private Registro registroEdicao;
        private readonly int idRegistro;
        private readonly TelaInicial telaInicial;
        public AtualizarRegistro(int idRegistro, TelaInicial telaInicial)
        {
            this.idRegistro = idRegistro;
            this.registroGlobal = new Registro();
            this.telaInicial = telaInicial;
            InitializeComponent();

            Load += AtualizarRegistro_Load;
        }

        private async void AtualizarRegistro_Load(object? sender, EventArgs e)
        {
            this.registroEdicao = await RegistroRepository.BuscarPorId(idRegistro);

            dtDataRegistro.Value = registroEdicao.DataDevolucao;
        }

        private async void btnSalvar_Click(object sender, EventArgs e)
        {
            registroGlobal.DataDevolucao = dtDataRegistro.Value;
            registroGlobal.Id = registroEdicao.Id;
            await RegistroRepository.AtualizarPorId(registroGlobal);
            await telaInicial.AtualizarTabela();
            this.Close();
            MessageBox.Show($"Data do registro movida para {dtDataRegistro.Value}.");
        }
    }
}
