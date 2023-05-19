using System;
using Microsoft.Data.SqlClient;
class Program
{

    static void Main(string[] args)
    {
        const string connectionString = "Server=localhost\\SQLEXPRESS,1433;Integrated Security=SSPI";
        // Vamos nos conectar ao banco usando o pacote Microsoft.Data.SqlClient (NUGGET)

        // Usando o pacote que criamos para se conectar ao banco de dados
        var connection = new SqlConnection(); // Objeto de conexão com o banco
    }
}