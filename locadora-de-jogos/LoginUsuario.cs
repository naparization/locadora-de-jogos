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
using locadora_de_jogos.Repositores;

namespace locadora_de_jogos
{
    public partial class LoginUsuario : Form
    {
        public LoginUsuario()
        {
            InitializeComponent();
        }

        private async void btnEntrar_Click(object sender, EventArgs e)
        {
            Cliente usuarioLogin = await ClienteRepository.BuscarPorIdentificador(txtUsuario.Text);

            if (usuarioLogin != null)
            {
                TelaInicial telaInicial = new TelaInicial(false, usuarioLogin.IdentificadorUnico);
                this.Hide();
                telaInicial.ShowDialog();
            } else
            {
                MessageBox.Show("Identificador inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoginUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
