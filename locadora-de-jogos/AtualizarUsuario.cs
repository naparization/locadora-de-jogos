using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GerenciamentoDeFuncionarios.Modelo;
using GerenciamentoDeJogos.Modelo;
using locadora_de_jogos.Repositores;
using locadora_de_jogos.Modelo;
using Timer = System.Windows.Forms.Timer;
using System.ComponentModel.DataAnnotations;
using CpfCnpjLibrary;


namespace locadora_de_jogos
{
    public partial class AtualizarUsuario : Form
    {
        public Cliente clienteGlobal = new Cliente();
        private Cliente clienteEdicao;
        private readonly int idUsuario;
        private readonly TelaInicial telaInicial;
        private Timer timer;
        public AtualizarUsuario(int idUsuario, TelaInicial telaInicial)
        {
            InitializeComponent();
            IniciarTimer();
            this.idUsuario = idUsuario;
            this.telaInicial = telaInicial;
            Load += AtualizarUsuario_Load;



        }

        private void IniciarTimer()
        {
            timer = new Timer();
            timer.Interval = 60;
            timer.Tick += FazerValidacao;
            timer.Start();
        }

        private void FazerValidacao(object? sender, EventArgs e)
        {
            Cliente cliente = new Cliente();

            cliente.Nome = txtNomeUsuario.Text;
            cliente.CPF = txtCpf.Text.Replace("-", "").Replace(".", "");
            cliente.Email = txtEmail.Text;
            cliente.Telefone = $"{txtDDD.Text.Replace("+", "").Replace(" ", "")}{txtTelefone.Text.Replace(" ", "").Replace("-", "")}";
            cliente.Genero = rbMasculino.Checked ? Genero.Masculino : rbFeminino.Checked ? Genero.Feminino : Genero.Outro;


            var stringBuilder = new StringBuilder();

            var listaDeErros = new List<ValidationResult>();

            bool CPFValido = Cpf.Validar(cliente.CPF);

            if (!CPFValido)
            {
                listaDeErros.Add(new ValidationResult("o CPF precisa ser válido."));
            }

            var contexto = new ValidationContext(cliente);
            Validator.TryValidateObject(cliente, contexto, listaDeErros, true);

            if (listaDeErros.Count > 0)
            {
                btnSalvar.Enabled = false;
                foreach (var erro in listaDeErros)
                {
                    stringBuilder.Append(erro.ErrorMessage + "\n");
                    txtErro.Text = stringBuilder.ToString();
                }
            }
            else
            {
                txtErro.Text = "";
                btnSalvar.Enabled = true;
            }

            clienteGlobal = cliente;
        }

        private async void AtualizarUsuario_Load(object? sender, EventArgs e)
        {
            this.clienteEdicao = await ClienteRepository.BuscarPorId(this.idUsuario);

            txtNomeUsuario.Text = clienteEdicao.Nome;
            txtCpf.Text = Cpf.FormatarComPontuacao(clienteEdicao.CPF);
            txtEmail.Text = clienteEdicao.Email;

            switch (clienteEdicao.Genero)
            {
                case Genero.Masculino:
                    rbMasculino.Checked = true;
                    rbFeminino.Checked = false;
                    rbOutro.Checked = false;
                    break;
                case Genero.Feminino:
                    rbMasculino.Checked = false;
                    rbFeminino.Checked = true;
                    rbOutro.Checked = false;
                    break;
                case Genero.Outro:
                    rbOutro.Checked = true;
                    rbMasculino.Checked = false;
                    rbFeminino.Checked = false;
                    break;
                default:
                    rbMasculino.Checked = false;
                    rbFeminino.Checked = false;
                    rbOutro.Checked = false;
                    break;
            }

            txtDDD.Text = clienteEdicao.Telefone.Substring(0, 2);
            txtTelefone.Text = clienteEdicao.Telefone.Substring(2, 9);

            clienteGlobal = this.clienteEdicao;
            clienteEdicao.Id = idUsuario;
            clienteGlobal.Id = this.clienteEdicao.Id;

        }

        private async void btnSalvar_Click(object sender, EventArgs e)
        {
            clienteGlobal.Id = idUsuario;
            await ClienteRepository.AtualizarPorId(clienteGlobal);
            await telaInicial.AtualizarTabela();
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
