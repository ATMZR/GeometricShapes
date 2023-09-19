using System.Data.SqlClient;

namespace SQLQueryExample
{
    class Program
    {
        static void Main(string[] args)        
        {        
            string connectionString = "Data Source=YourServer;Initial Catalog=YourDatabase;User ID=YourUsername;Password=YourPassword";

            using (SqlConnection connection = new SqlConnection(connectionString))            
            {
                connection.Open();

                string sqlQuery = "SELECT P.Name AS 'Имя продукта', C.Name AS 'Имя категории' " +
                                  "FROM Products P " +
                                  "LEFT JOIN ProductCategory PC ON P.ProductId = PC.ProductId " +
                                  "LEFT JOIN Categories C ON PC.CategoryId = C.CategoryId";

                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string? productName = reader["Имя продукта"] == DBNull.Value ? string.Empty : reader["Имя продукта"].ToString();
                            string? categoryName = reader["Имя категории"] == DBNull.Value ? string.Empty : reader["Имя категории"].ToString();
                            Console.WriteLine(productName + " - " + categoryName);
                            
                        }
                    }
                }
            }
        }
    }
}