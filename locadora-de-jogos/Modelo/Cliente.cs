using System.ComponentModel.DataAnnotations;

namespace GerenciamentoDeFuncionarios.Modelo
{
    public class Funcionario
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo nome é obrigatório.")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "O campo nome deve ter no mínimo 3 caracteres e no máximo 100.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo Email é obrigatório.")]
        [EmailAddress(ErrorMessage = "O campo email é inválido")]
        public string Email { get; set; }

        public string Sexo { get; set; }

        public DateTime DataCadastro { get; set; }
    }
}