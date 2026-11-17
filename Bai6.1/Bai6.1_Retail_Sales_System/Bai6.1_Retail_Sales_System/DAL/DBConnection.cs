using System.Data.SqlClient;

namespace Bai6._1_Retail_Sales_System.DAL
{
    public static class DBConnection
    {
        private static readonly string connectionString =
            @"Data Source=.\SQLEXPRESS;Initial Catalog=SalesDB;Integrated Security=True;TrustServerCertificate=True;";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}