using System.Data;
using System.Data.SqlClient;

namespace GerenciamentoDeFuncionarios.Banco.Configuracao
{
    public class ConexaoBanco
    {
        public IDbConnection CriarConexao()
        {
            return new SqlConnection("Server=(localdb)\\MSSQLLocalDB; Database=gerenciamento_funcionarios; Trusted_Connection=True;");
        }
    }
}