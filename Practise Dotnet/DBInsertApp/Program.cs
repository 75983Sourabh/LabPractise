using MySql.Data.MySqlClient;
Console.WriteLine("Welcome to Sourabh Database");


MySqlConnection conn=new MySqlConnection();
conn.ConnectionString="server=192.168.10.150; port=3306;user=dac40;password=welcome;database=dac40";
string query="insert into product values(2,Dal','Dal is famous as the most delicious dish')";
MySqlCommand command=new MySqlCommand(query,conn);


try
{
    conn.Open();
  
   command.ExecuteNonQuery();
        
 }
  

catch (Exception e)
{
    Console.WriteLine(e.Message);
    
}
finally{
    conn.Close();
}

