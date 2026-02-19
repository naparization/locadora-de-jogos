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
