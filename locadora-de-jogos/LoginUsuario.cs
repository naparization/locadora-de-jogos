using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace locadora_de_jogos
{
    public partial class LoginUsuario : Form
    {
        public LoginUsuario()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Length != 11)
            {
                txtErro.Text = "CPF informado inválido.";
                return;
            }
            TelaInicial telaInicial = new TelaInicial(false);
            this.Hide();
            telaInicial.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoginUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
