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
    public partial class TelaInicial : Form
    {
        private readonly bool isAdmin;
        public byte option;
        public TelaInicial(bool isAdmin)
        {

            this.isAdmin = isAdmin;
            this.option = 0;
                InitializeComponent();
            if (isAdmin)
            {
                btnNovoAlugar.Text = "Novo";
                
                btnExcluirDevolver.Text = "Excluir";
            } else
            {
                btnNovoAlugar.Text = "Alugar";
                btnExcluirDevolver.BackColor = Color.MediumPurple;
                btnEditar.Enabled = false;
                btnExcluirDevolver.Enabled = false;
                btnExcluirDevolver.Text = "Devolver";
            }

        }

        private void btnExcluirDevolver_Click(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnNovoAlugar_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            this.option = 2;
            if (!isAdmin)
            {
                btnNovoAlugar.Enabled = false;
                btnEditar.Enabled = false;
                btnExcluirDevolver.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.option = 1;
            if (!isAdmin)
            {
                btnNovoAlugar.Enabled = false;
                btnEditar.Enabled= true;
                btnExcluirDevolver.Enabled= false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.option = 0;
            if (!isAdmin)
            {
                btnNovoAlugar.Enabled = true;
                btnEditar.Enabled = false;
                btnExcluirDevolver.Enabled = false;
            }
        }
    }
}
