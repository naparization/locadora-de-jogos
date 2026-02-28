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
        private readonly string idUsuario;
        public byte option;
        public TelaInicial(bool isAdmin, string idUsuario)
        {
            
            this.isAdmin = isAdmin;
            this.idUsuario = idUsuario;
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
                    if (isAdmin)
                    {
                        var clientes = await ClienteRepository.ObterClientes();
                        dgvDados.DataSource = new BindingList<Cliente>(clientes.ToList());
                    } else
                    {
                        var cliente = await ClienteRepository.BuscarPorIdentificador(idUsuario);
                        dgvDados.DataSource = new BindingList<Cliente> { cliente };
                    }

                    break;
                case 2:
                    // tabela registros
                    if (isAdmin)
                    {
                        var registros = await RegistroRepository.ObterRegistros();
                        dgvDados.DataSource = new BindingList<Registro>(registros.ToList());
                    } else
                    {
                        var registros = await RegistroRepository.BuscarPorIdentificador(idUsuario);
                        dgvDados.DataSource = new BindingList<Registro>(registros.ToList());
                    }

                        break;
                default:
                    // deu errado
                    var padrao = await JogoRepository.ObterJogos();
                    dgvDados.DataSource = new BindingList<Jogo>(padrao.ToList());
                    break;
            }
                
            

        }

        private async void btnExcluirDevolver_Click(object sender, EventArgs e)
        {
            if (isAdmin)
            {
                var tabela = dgvDados.SelectedRows[0].Cells[1].Value;

                if (tabela == null)
                {
                    return;
                }
                        string tabelaNome = tabela.ToString();

                
                switch (option)
                {

                    case 0:

                        var retornoJogo = MessageBox.Show($"Tem certeza que deseja excluir jogo {tabelaNome}?", "Excluir jogo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (retornoJogo == DialogResult.Yes)
                        {
                            int idJogo = (int)dgvDados.SelectedRows[0].Cells[0].Value;
                            await JogoRepository.DeletarJogo(idJogo);
                            await AtualizarTabela();
                            
                        }
                        break;
                    case 1:
                        var retornoCliente = MessageBox.Show($"Tem certeza que deseja excluir cliente {tabelaNome}?", "Excluir cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (retornoCliente == DialogResult.Yes)
                        {
                            int idCliente = (int)dgvDados.SelectedRows[0].Cells[0].Value;
                            await ClienteRepository.DeletarCliente(idCliente);
                            await AtualizarTabela();

                        }
                        break;
                    default:
                        MessageBox.Show("Não definido.");
                        break;
                    case 2:
                        var tabela2 = dgvDados.SelectedRows[0].Cells[2].Value;

                        if (tabela2 == null)
                        {
                            return;
                        }
                        string tabelaNome2 = tabela2.ToString();
                        var retornoRegistro = MessageBox.Show($"Tem certeza que deseja excluir este registro? \n[{tabelaNome}, {tabelaNome2}]", "Excluir registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (retornoRegistro == DialogResult.Yes)
                        {
                            int idRegistro = (int)dgvDados.SelectedRows[0].Cells[0].Value;
                            await RegistroRepository.DeletarRegistro(idRegistro);
                            await AtualizarTabela();
                        }
                        break;
                }
            } else
            {

                int idRegistro = (int)dgvDados.SelectedRows[0].Cells[0].Value;
                
                var calculoAluguel = new CalculoAluguel(idRegistro, this);
                calculoAluguel.ShowDialog();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvDados.SelectedRows[0].Cells[0].Value == null)
            {
                return;
            }
            try
            {
                switch (option)
                {
                    case 0:
                        int idJogo = (int)dgvDados.SelectedRows[0].Cells[0].Value;
                        var atualizarJogo = new AtualizarJogo(idJogo, this);
                        atualizarJogo.ShowDialog();
                        break;
                    case 1:
                        int idUsuario = (int)dgvDados.SelectedRows[0].Cells[0].Value;
                        var atualizarUsuario = new AtualizarUsuario(idUsuario, this);
                        atualizarUsuario.ShowDialog();
                        break;
                    case 2:
                        int idRegistro = (int)dgvDados.SelectedRows[0].Cells[0].Value;
                        var atualizarRegistro = new AtualizarRegistro(idRegistro, this);
                        atualizarRegistro.ShowDialog();
                        break;
                    default:
                        break;

                }
            } catch (Exception)
            {
                return;
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
                        var cadastroCliente = new CadastroUsuarios(this);
                        this.Hide();
                        cadastroCliente.ShowDialog();
                        this.Show();
                        break;
                    case 2:
                        var cadastroRegistros = new CadastroRegistros(this);
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
            int idJogo = (int)dgvDados.SelectedRows[0].Cells[0].Value;
             
            var alugarJogo = new AlugarJogo(idJogo, idUsuario, this);
            alugarJogo.ShowDialog();
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
