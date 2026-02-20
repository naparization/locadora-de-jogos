using System.ComponentModel.DataAnnotations;
using locadora_de_jogos.Modelo;

namespace GerenciamentoDeFuncionarios.Modelo
{
    public class Cliente
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo nome é obrigatório.")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "O campo nome deve ter no mínimo 3 caracteres e no máximo 100.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo CPF é obrigatório.")]
        [StringLength(11, MinimumLength = 11, ErrorMessage = "O campo CPF é inválido.")]
        public string CPF { get; set; }

        public Genero Genero { get; set; }

        [Required(ErrorMessage = "O campo Email é obrigatório.")]
        [EmailAddress(ErrorMessage = "O campo Email é inválido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O campo Telefone é obrigatório.")]
        [StringLength(9, MinimumLength = 9, ErrorMessage = "O Telefone deve conter pelo menos 9 dígitos.")]
        public string Telefone { get; set; }

        public DateTime DataCadastro { get; set; } 

        public string IdentificadorUnico { get; set; }
    }
}