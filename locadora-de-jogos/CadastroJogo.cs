using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using Timer = System.Windows.Forms.Timer;

namespace locadora_de_jogos
{
    public partial class CadastroJogo : Form
    {
        private Timer frameTimer;
        public CadastroJogo()
        {

            InitializeComponent();
            IniciarTimer();
        }

        private void IniciarTimer()
        {
            frameTimer = new Timer();
            frameTimer.Interval = 32;
            frameTimer.Tick += RodarTodoFrame_Tick;
            frameTimer.Start();
        }

        private void RodarTodoFrame_Tick(object sender, EventArgs e)
        {
            try
            {
                decimal valorMonetario = decimal.Parse(txtPreco.Text);
                if (txtNomeJogo.Text.Length > 0 && valorMonetario > 0)
                {
                    btnSalvar.Enabled = true;
                }
                else
                {
                    btnSalvar.Enabled = false;
                }




            }
            catch (Exception ex)
            {

                btnSalvar.Enabled = false;

            }


        }

        private void button1_Click(object sender, EventArgs e)
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
    }
}
