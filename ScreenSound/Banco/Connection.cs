using System.Data.SqlClient;

namespace ScreenSound.Banco;

public class Connection
{
    // Local
    private string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ScreenSound;Integrated Security=True;Encrypt=False;";

    public SqlConnection ObterConexao()
    {
        return new SqlConnection(connectionString);
    }
}
