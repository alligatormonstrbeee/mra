using System.Data.SqlClient;

namespace FurnitureApp
{
    public static class Database
    {
        private static string connectionString = "Server=DESKTOP-8AKMJ0D\\SQLEXPRESS;Database=FurnitureManagementDB;Trusted_Connection=True;";

        public static SqlConnection GetConnection()
        {
            // Здесь не нужен блок using, так как соединение возвращается из метода
            return new SqlConnection(connectionString);
        }
    }
}