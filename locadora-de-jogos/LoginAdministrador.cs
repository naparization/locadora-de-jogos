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
    public partial class LoginAdministrador : Form
    {
        public LoginAdministrador()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Admin" && txtSenha.Text == "1234")
            {
                TelaInicial telaInicial = new TelaInicial(true);
                this.Hide();
                telaInicial.ShowDialog();
            } else
            {
                MessageBox.Show("Login ou Senha incorretos.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                
            
        }
    }
}
