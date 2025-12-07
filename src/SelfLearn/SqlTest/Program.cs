using Microsoft.Data.SqlClient;

var connString =
    "Server=localhost,1433;Database=master;User Id=sa;Password=Meiwa123;TrustServerCertificate=True;";

using var conn = new SqlConnection(connString);

try
{
    conn.Open();
    Console.WriteLine("SQL Server に接続できました！");
}
catch (Exception ex)
{
    Console.WriteLine("接続失敗: " + ex.Message);
}