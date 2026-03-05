using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GerenciamentoDeFuncionarios.Modelo;
using GerenciamentoDeJogos.Modelo;
using locadora_de_jogos.Modelo;
using locadora_de_jogos.Repositores;
using Timer = System.Windows.Forms.Timer;
using CpfCnpjLibrary;



namespace locadora_de_jogos
{
    public partial class CadastroUsuarios : Form
    {
        private Timer timer;
        public int anos;
        private readonly TelaInicial telaInicial;
        public Cliente clienteGlobal;
        public CadastroUsuarios(TelaInicial telaInicial)
        {
            InitializeComponent();
            IniciarTimer();

            this.telaInicial = telaInicial;
            this.anos = 0;
            dtNascimento.MinDate = new DateTime(1900, 1, 1);
            dtNascimento.MaxDate = DateTime.Today;
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
            cliente.DataNascimento = dtNascimento.Value;
            DateTime dataAtual = DateTime.Now;
            var stringBuilder = new StringBuilder();


            anos = dataAtual.Year - cliente.DataNascimento.Year;

            if (dataAtual < cliente.DataNascimento.AddYears(anos))
            {
                anos--;
            }

            bool CPFValido = Cpf.Validar(cliente.CPF);


            

            var listaDeErros = new List<ValidationResult>();

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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtNomeJogo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void rbRPG_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbShooter_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private async void btnSalvar_Click(object sender, EventArgs e)
        {
            if (anos < 18)
            {
                MessageBox.Show("Somente pessoas acima de 18 anos podem criar uma conta.");
                return;
            }
            Random aleatorio = new Random();
            DateTime dataAtual = DateTime.Now;
            clienteGlobal.DataCadastro = DateTime.Now;
            clienteGlobal.DataNascimento = dtNascimento.Value;
            string identificador;
            do
            {
                identificador = clienteGlobal.Nome.Substring(0, 2);  
                identificador = identificador + "-" + aleatorio.Next(1000, 9999);
                identificador = identificador + $"-{dataAtual.Day}{dataAtual.Month}";
            } while (await ClienteRepository.BuscarPorIdentificador(identificador) != null);
            clienteGlobal.IdentificadorUnico = identificador;
            await ClienteRepository.Adicionar(clienteGlobal);
            await telaInicial.AtualizarTabela();
            this.Close();
        }
    }
}
