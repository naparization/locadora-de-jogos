using GerenciamentoDeFuncionarios.Modelo;
using GerenciamentoDeGenero.Modelo;

namespace GerenciamentoDeJogos.Modelo
{
    public class Jogo
    {
        public int Id { get; set; }

        public string Titulo { get; set; } = string.Empty;

        public GeneroJogo Genero { get; set; }

        public decimal Preco { get; set; }

        public DateTime DataLancamento { get; set; }
    }
}
