using MySql.Data.MySqlClient;
Console.WriteLine("Welcome to the Sourabh Daatabase");
MySqlConnection conn=new MySqlConnection();
conn.ConnectionString="server=192.168.10.150;port=3306;user=dac40;password=welcome;database=dac40";
string query="select * from product";
MySqlCommand command = new MySqlCommand(query, conn);
try
{
    conn.Open();
    MySqlDataReader reader=command.ExecuteReader();
    while(reader.Read()){
        int id=int.Parse(reader["id"].ToString());
        string Title=reader["Title"].ToString();
        string Description=reader["Description"].ToString();
   Console.WriteLine(id+"   "+Title+"   "+Description);
    }
    reader.Close();

}
catch (Exception e)
{
    
Console.WriteLine(e.Message);
}
finally{
    conn.Close();

}