﻿using MySql.Data.MySqlClient;  //using package of MySql.Data ------>Command----->dotnet add package MySql.Data
System.Console.WriteLine("Welcome to The Deletion Command of Sourabh");

MySqlConnection conn=new MySqlConnection(); //--------->creating a connection
conn.ConnectionString="server=192.168.10.150;port=3306;user=dac40;password=welcome;database=dac40";

System.Console.WriteLine("Enter the id of product you want to delete");
int id=int.Parse(Console.ReadLine());//--->parsing a 
string query="delete  from product where id=@id";

MySqlCommand command=new MySqlCommand(query,conn);

command.Parameters.AddWithValue("@id",id);


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
