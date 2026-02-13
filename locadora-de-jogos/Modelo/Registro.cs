namespace GerenciamentoDeRegistros.Modelo
{
    public class Registro
    {
        public int Id { get; set; }

        public string NomeDoUsuario { get; set; }

        public string NomeDoJogo { get; set; }

        public DateTime DataAluguel { get; set; }

        public DateTime DataDevolucao { get; set; }
    }
}
