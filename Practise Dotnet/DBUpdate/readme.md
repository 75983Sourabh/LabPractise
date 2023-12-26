In this update program there will be command like
==================================================
dotnet new console -o DBUpdate
cd DBUpdate
dotnet new sln
dotnet add package MySql.Data
---------------------------------------------------
then i use 
---using MySql.Data.MySqlClient;
---then for output first i will create a write method
----then connection created
----connection Url
-----string url
-----MySqlCommand
-----try catch loop
-----under try loop   
**** command.ExecuteNonQuery();
------under catch loop
exception method
-----finally method which is created for conn.Close(); this method is called always when progran is run or not
