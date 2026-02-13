using Dapper;
using GerenciamentoDeFuncionarios.Banco.Configuracao;
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

    }
}
