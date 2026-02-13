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
    }
}
