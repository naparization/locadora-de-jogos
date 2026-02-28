using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using locadora_de_jogos.Repositores;

namespace locadora_de_jogos
{
    public partial class CalculoAluguel : Form
    {
        private readonly TelaInicial telaInicial;
        private readonly int idRegistro;
        public CalculoAluguel(int idRegistro, TelaInicial telaInicial)
        {
            this.telaInicial = telaInicial;
            this.idRegistro = idRegistro;
            InitializeComponent();

            Load += CalculoAluguel_Load;
        }

        private async void CalculoAluguel_Load(object? sender, EventArgs e)
        {
            
            var registroDoJogo = await RegistroRepository.BuscarPorId(idRegistro);
            var nomeJogo = await RegistroRepository.BuscarPorIdDoJogo(idRegistro);



            var jogo = await JogoRepository.BuscarPorId(nomeJogo.Id);
            

            txtNomeJogo.Text = $"Jogo: {jogo.Titulo} ";

            double precoJogo = double.Parse(jogo.Preco.ToString());
            double fatura = precoJogo * 0.15;
            DateTime dataAtual = DateTime.Now;
            if (registroDoJogo.DataDevolucao < dataAtual)
            {
                TimeSpan diasDeDiferenca = dataAtual - registroDoJogo.DataDevolucao;

                int diasDeMulta = diasDeDiferenca.Days;

                txtMulta.Text = $"Atraso de {diasDeMulta} dia(s).";

                int y = 1;
                double valorextra = fatura * 0.05;
                do
                {
                    fatura = fatura + valorextra;
                    y++;
                } while (y <= diasDeMulta);


            }

            txtFatura.Text = $"{fatura:F2}";


        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string metodoDePagamento = rbCredito.Checked ? "Cartão" : rbBoleto.Checked ? "Boleto" : "Pix";

            MessageBox.Show($"Pagamento realizado com sucesso no {metodoDePagamento}.", "Fatura paga com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            await RegistroRepository.DeletarRegistro(idRegistro);
            await telaInicial.AtualizarTabela();
            this.Close();
        }
    }
}
