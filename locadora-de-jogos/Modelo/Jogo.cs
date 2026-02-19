using System.ComponentModel.DataAnnotations;
using GerenciamentoDeFuncionarios.Modelo;
using GerenciamentoDeGenero.Modelo;

namespace GerenciamentoDeJogos.Modelo
{
    public class Jogo
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo Título é obrigatório.")]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "O campo nome deve ter no mínimo 1 caracter e no máximo 100.")]
        public string Titulo { get; set; } = string.Empty;

        public GeneroJogo Genero { get; set; }

        public decimal Preco { get; set; }

        public DateTime DataLancamento { get; set; }
    }
}
