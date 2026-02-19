using Dapper;
using GerenciamentoDeFuncionarios.Banco.Configuracao;
using GerenciamentoDeFuncionarios.Modelo;
using GerenciamentoDeJogos.Modelo;

namespace locadora_de_jogos.Repositores
{
    public class JogoRepository
    {
        private static readonly BancoDeDados bancoDeDados = new BancoDeDados();

        public static async Task<IEnumerable<Jogo>> ObterJogos()
        {
            var jogos = await bancoDeDados.CriarConexao()
                .QueryAsync<Jogo>(
                @"
                  SELECT
                    Id,
                    Titulo,
                    IdGenero AS Genero,
                    Preco,
                    DataLancamento
                  FROM
                   Jogos
                ");

            return jogos;
        }

        public static async void Adicionar(Jogo jogo)
        {
            await bancoDeDados.CriarConexao().QueryAsync(
                @"
                    INSERT INTO Jogos (Titulo, IdGenero, Preco, DataLancamento)
                    VALUES (@Titulo, @Genero, @Preco, @DataLancamento);
                ", jogo);
        }

        internal static async Task DeletarJogo(int idJogo)
        {
            try
            {
                await bancoDeDados.CriarConexao().QueryAsync(
                @"
                    DELETE FROM Jogos
                    WHERE id = @Id
                ", new { Id = idJogo });
                MessageBox.Show($"Jogo {idJogo} foi deletado com sucesso.", "Excluir funcionário", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            } catch (Exception)
            {
                MessageBox.Show($"O jogo de ID {idJogo} não pode ser deletado, pois está sendo referenciado em um dos registros.", "Erro ao deletae", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
        }

        public static async Task<Jogo> BuscarPorId(int idJogo)
        {
            var funcionario = await bancoDeDados.CriarConexao()
                .QueryFirstOrDefaultAsync<Jogo>(
                @"
                    SELECT
                        Id,
                        Nome,
                        Email,
                        Salario,
                        Sexo,
                        TipoContrato,
                        DataCadastro,
                        DataAtualizacao
                FROM
                    Funcionario
                WHERE
                    Id = @Id
                ", new { Id = idJogo });

            return funcionario;
        }
    }
}
