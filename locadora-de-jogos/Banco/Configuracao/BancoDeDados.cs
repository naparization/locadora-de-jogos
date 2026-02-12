using System.Data;
using System.Data.SqlClient;

namespace GerenciamentoDeFuncionarios.Banco.Configuracao
{
    public class ConexaoBanco
    {
        public IDbConnection CriarConexao()
        {
            return new SqlConnection("Server=(localdb)\\MSSQLLocalDB; Database=locadora_super_jogos; Trusted_Connection=True;");
        }
    }
}