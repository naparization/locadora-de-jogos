using Dapper;
using GerenciamentoDeFuncionarios.Banco.Configuracao;
using GerenciamentoDeJogos.Modelo;
using GerenciamentoDeRegistros.Modelo;

namespace locadora_de_jogos.Repositores
{
    public class RegistroRepository
    {
        private static readonly BancoDeDados bancoDeDados = new BancoDeDados();

        public static async Task<IEnumerable<Registro>> ObterRegistros()
        {
            var registro = await bancoDeDados.CriarConexao()
                .QueryAsync<Registro>(
                @"
                    SELECT 
                    R.Id,
                    U.Nome AS NomeDoUsuario,
                    J.Titulo AS NomeDoJogo,
                    R.DataAluguel,
                    R.DataDevolucao
                    FROM Registros R
                    INNER JOIN Usuarios U ON R.IdUsuario = U.Id
                    INNER JOIN Jogos J ON R.IdJogo = J.Id;
                ");
            return registro;
        }

        internal static async Task Adicionar(Registro registro)
        {
            await bancoDeDados.CriarConexao().QueryAsync<Registro>(
               @"
                    INSERT INTO Registros (IdUsuario, IdJogo, DataAluguel, DataDevolucao)
                    VALUES (@NomeDoUsuario, @NomeDoJogo, @DataAluguel, @DataDevolucao);
                ", registro);
        }

        public static async Task<Registro> BuscarPorId(int idRegistro)
        {
            var registro = await bancoDeDados.CriarConexao()
                .QueryFirstOrDefaultAsync<Registro>(
                @"
                    SELECT
                        Id,
                        DataDevolucao
                FROM
                    Registros
                WHERE
                    Id = @Id
                ", new { Id = idRegistro });

            return registro;
        }

        public static async Task<IEnumerable<Registro>> BuscarPorIdentificador(string identificador)
        {
            var registro = await bancoDeDados.CriarConexao().QueryAsync<Registro>(
                @"
                   SELECT 
                    R.Id,
                    U.Nome as NomeDoUsuario,
                    J.Titulo AS NomeDoJogo,
                    R.DataAluguel,
                    R.DataDevolucao,
                    R.IdUsuario
                    FROM Registros R
                    INNER JOIN Usuarios U ON R.IdUsuario = U.Id
                    INNER JOIN Jogos J ON R.IdJogo = J.Id
                    WHERE U.IdentificadorUnico = @IdentificadorUnico;
                ", new {IdentificadorUnico = identificador});
            return registro;
        }


        internal static async Task AtualizarPorId(Registro registro)
        {
            await bancoDeDados.CriarConexao().QueryAsync(
               @"
                    UPDATE Registros
                    SET
                    DataDevolucao = @DataDevolucao
                    WHERE Id = @Id
                ", registro

               );
        }

        internal static async Task DeletarRegistro(int idRegistro)
        {
            try
            {
                await bancoDeDados.CriarConexao().QueryAsync(
                @"
                    DELETE FROM Registros
                    WHERE id = @Id
                ", new { Id = idRegistro });
                MessageBox.Show($"Registrado deletado com sucesso.", "Excluir registro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception)
            {
                return;
            }
        }
    }
}
