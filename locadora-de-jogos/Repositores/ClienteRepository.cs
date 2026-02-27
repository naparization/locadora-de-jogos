
using Dapper;
using GerenciamentoDeFuncionarios.Banco.Configuracao;
using GerenciamentoDeFuncionarios.Modelo;
using GerenciamentoDeJogos.Modelo;

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
                    Genero,
                    Email,
                    Telefone,
                    DataCadastro,
                    IdentificadorUnico,
                    DataNascimento
                  FROM
                   Usuarios
                ");

            return clientes;
        }

        internal static void Adicionar(Cliente cliente)
        {
            bancoDeDados.CriarConexao().QueryAsync<Cliente>(
                @"
                    INSERT INTO Usuarios (Nome, CPF, Genero, Email, Telefone, DataCadastro, IdentificadorUnico, DataNascimento)
                    VALUES (@Nome, @CPF, @Genero, @Email, @Telefone, @DataCadastro, @IdentificadorUnico, @DataNascimento);
                ", cliente);
        }

        public static async Task<Cliente> BuscarPorId(int idUsuario)
        {
            var cliente = await bancoDeDados.CriarConexao()
                .QueryFirstOrDefaultAsync<Cliente>(
                @"
                    SELECT
                        Nome,
                        CPF,
                        Genero,
                        Email,
                        Telefone,
                        DataCadastro,
                        IdentificadorUnico,
                        DataNascimento
                FROM
                    Usuarios
                WHERE
                    Id = @Id
                ", new { Id = idUsuario });

            return cliente;
        }

        public static async Task<Cliente> BuscarPorIdentificador(string idUsuario)
        {
            var cliente = await bancoDeDados.CriarConexao()
                .QueryFirstOrDefaultAsync<Cliente>(
                @"
                    SELECT
                        Id,
                        Nome,
                        CPF,
                        Genero,
                        Email,
                        Telefone,
                        DataCadastro,
                        IdentificadorUnico,
                        DataNascimento
                FROM
                    Usuarios
                WHERE
                    IdentificadorUnico = @IdentificadorUnico
                ", new { IdentificadorUnico = idUsuario });

            return cliente;
        }

        internal static async Task AtualizarPorId(Cliente clienteGlobal)
        {
            await bancoDeDados.CriarConexao().QueryAsync(
                @"
                    UPDATE Usuarios
                    SET
                    Nome = @Nome,
                    CPF = @CPF,
                    Genero = @Genero,
                    Email = @Email,
                    Telefone = @Telefone
                    WHERE Id = @Id
                ", clienteGlobal);
        }

        internal static async Task DeletarCliente(int idCliente)
        {
            try
            {
                await bancoDeDados.CriarConexao().QueryAsync(
                @"
                    DELETE FROM Usuarios
                    WHERE id = @Id
                ", new { Id = idCliente });
                MessageBox.Show($"Cliente {idCliente} foi deletado com sucesso.", "Excluir cliente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception)
            {
                MessageBox.Show($"O Cliente de ID {idCliente} não pode ser deletado, pois está sendo referenciado em um dos registros.", "Erro ao deletar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
