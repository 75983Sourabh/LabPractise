using MySql.Data.MySqlClient;

Console.WriteLine("Welcome to Sourabh Update Database");
MySqlConnection conn=new MySqlConnection();
conn.ConnectionString="server=192.168.10.150;port=3306;user=dac40;password=welcome;database=dac40";

string query="Update product set Title='Palak paneer' where id=1";
MySqlCommand command=new MySqlCommand(query,conn);
try
{
    conn.Open();
    command.ExecuteNonQuery();

}
catch (System.Exception e)
{
    
  System.Console.WriteLine(e.Message);
}
finally{
    conn.Close();
}