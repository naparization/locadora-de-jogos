
using Dapper;
using GerenciamentoDeFuncionarios.Banco.Configuracao;
using GerenciamentoDeFuncionarios.Modelo;

namespace locadora_de_jogos.Repositores
{
    public class ClienteRepository
    {
        private static readonly BancoDeDados bancoDeDados = new BancoDeDados();

        public static async Task<IEnumerable<Cliente>> ObterClientes()
        {
            var clientes = await bancoDeDados.CriarConexao()
                .QueryAsync<Cliente>(
                @"
                  SELECT
                    Id,
                    Nome,
                    CPF,
                    Email,
                    Telefone,
                    DataCadastro
                  FROM
                   Usuarios
                ");

            return clientes;
        }
    }
}
