using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GerenciamentoDeFuncionarios.Modelo;
using GerenciamentoDeJogos.Modelo;
using GerenciamentoDeRegistros.Modelo;
using locadora_de_jogos.Repositores;

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
            // botão multifuncional, caso seja Admin o layout é Novo/Editar/Excluir
            // caso seja usuário padrão então Alugar/Editar/Devoler
            // botão devolver muda de vermelho para uma cor lavanda, pois é menos ameaçador
            // devolver o livro é algo bom, não queremos desencorajar o cliente :3
            if (isAdmin)
            {
                btnNovoAlugar.Text = "Novo";
                
                btnExcluirDevolver.Text = "Excluir";
            } else
            {
                btnNovoAlugar.Text = "Alugar";
                btnExcluirDevolver.BackColor = Color.Gray;
                btnEditar.Enabled = false;
                btnEditar.BackColor = Color.Gray;
                btnExcluirDevolver.Enabled = false;
                btnExcluirDevolver.Text = "Devolver";
            }

            Load += TelaInicial_Load;

        }

        private async void TelaInicial_Load(object? sender, EventArgs e)
        {
            await AtualizarTabela();
        }

        public async Task AtualizarTabela()
        {
            
            dgvDados.Rows.Clear();
            switch (option)
            {
                case 0:
                    var jogos = await JogoRepository.ObterJogos();
                    dgvDados.DataSource = new BindingList<Jogo>(jogos.ToList());
                    break;
                case 1:
                    var clientes = await ClienteRepository.ObterClientes();
                    dgvDados.DataSource = new BindingList<Cliente>(clientes.ToList());
                    break;
                case 2:
                    // tabela registros
                    var registros = await RegistroRepository.ObterRegistros();
                    dgvDados.DataSource = new BindingList<Registro>(registros.ToList());
                    break;
                default:
                    // deu merda
                    var padrao = await JogoRepository.ObterJogos();
                    dgvDados.DataSource = new BindingList<Jogo>(padrao.ToList());
                    break;
            }
                
            

        }

        private async void btnExcluirDevolver_Click(object sender, EventArgs e)
        {
            if (isAdmin)
            {
                switch (option)
                {
                    case 0:
                        string nomeJogo = dgvDados.SelectedRows[0].Cells[1].Value.ToString();
                        var retorno = MessageBox.Show($"Tem certeza que deseja excluir jogo {nomeJogo}?", "Excluir jogo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (retorno == DialogResult.Yes)
                        {
                            int idJogo = (int)dgvDados.SelectedRows[0].Cells[0].Value;
                            await JogoRepository.DeletarJogo(idJogo);
                            await AtualizarTabela();
                            
                        }
                        break;
                    default:
                        MessageBox.Show("Não definido.");
                        break;
                }
            } else
            {

            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            switch (option) {
                case 0:
                    int IdJogo = (int)dgvDados.SelectedRows[0].Cells[0].Value;
                    var atualizarJogo = new AtualizarJogo(IdJogo, this);
                    atualizarJogo.ShowDialog();

                    break;                   
                default:
                    break;

            } 
        }

        private void btnNovoAlugar_Click(object sender, EventArgs e)
        {
            // código do administrador
            if (isAdmin)
            {
                switch (option)
                {
                    // 0 = Jogos
                    // 1 = Usuários
                    // 2 = Registros
                    case 0:
                       
                        var cadastroJogos = new CadastroJogo(this);
                        this.Hide();
                        cadastroJogos.ShowDialog();
                        this.Show();
                        break;
                    case 1:
                        var cadastroCliente = new CadastroUsuarios();
                        this.Hide();
                        cadastroCliente.ShowDialog();
                        this.Show();
                        break;
                    case 2:
                        var cadastroRegistros = new CadastroRegistros();
                        this.Hide();
                        cadastroRegistros.ShowDialog();
                        this.Show();
                        break;
                    default:
                        // Esta função deveria ser impossível, se este código rodar: Fudeu.
                        MessageBox.Show("Algo deu errado, tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        option = 0;
                        break;
                }
                return;
            }
            // código do usuário padrão 
        }

        private async void btnRegistro_Click(object sender, EventArgs e)
        {
            
            this.option = 2;
            await AtualizarTabela();
            if (!isAdmin)
            {
                btnNovoAlugar.Enabled = false;
                btnNovoAlugar.BackColor = Color.Gray;
                btnEditar.Enabled = false;
                btnEditar.BackColor = Color.Gray;
                btnExcluirDevolver.Enabled = true;
                btnExcluirDevolver.BackColor = Color.FromArgb(225, 156 , 255);
            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            this.option = 1;
            await AtualizarTabela();
            if (!isAdmin)
            {
                btnNovoAlugar.Enabled = false;
                btnNovoAlugar.BackColor = Color.Gray;
                btnEditar.Enabled= true;
                btnEditar.BackColor = Color.FromArgb(255, 255, 192);
                btnExcluirDevolver.Enabled= false;
                btnExcluirDevolver.BackColor = Color.Gray;
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            this.option = 0;
            await AtualizarTabela();
            if (!isAdmin)
            {
                btnNovoAlugar.Enabled = true;
                btnNovoAlugar.BackColor = Color.FromArgb(192, 255, 192);
                btnEditar.Enabled = false;
                btnEditar.BackColor = Color.Gray;
                btnExcluirDevolver.Enabled = false;
                btnExcluirDevolver.BackColor = Color.Gray;
            }
        }
    }
}
