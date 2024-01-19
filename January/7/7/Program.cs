using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;

var builder = new ConfigurationBuilder();
builder.AddJsonFile("Setings.json");

var config = builder.Build();

using SqlConnection conn = new(config.GetConnectionString("Default"));

conn.Open();

//Request 1

var command = new SqlCommand("select COUNT(*) from People", conn);

var res1 = command.ExecuteScalar();

Console.WriteLine(res1);

//Request 2

command = new SqlCommand("select AVG(Age) from People", conn);

var res2 = command.ExecuteScalar();

Console.WriteLine(res2);

//Request 3

command = new SqlCommand("select MAX(Age) from People", conn);

var res3 = command.ExecuteScalar();

Console.WriteLine(res3);

//Request 4

command = new SqlCommand("delete from People where Age < 18", conn);

command.ExecuteNonQuery();

//Request 5 

command = new SqlCommand("insert into People ([Name], [Surname], [Age]) values (N'Kenan', N'Memmedli', 16)", conn);

command.ExecuteNonQuery();

//Request 6

command = new SqlCommand("update People set Name = N'Ibragim' where Age = 18", conn);

command.ExecuteNonQuery();