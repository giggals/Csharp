using System;
using System.Data.SqlClient;

class Program
{
    static void Main(string[] args)
    {
        int minionId = int.Parse(Console.ReadLine());

        using (SqlConnection connection = new SqlConnection(Configuration.ConnectionString))
        {
            connection.Open();

            string updateAge = $"EXEC dbo.usp_GetOlder {minionId}";
            using (SqlCommand command = new SqlCommand(updateAge , connection))
            {
                command.ExecuteNonQuery();
            }

            string nameAndAge = $"SELECT Name , Age FROM Minions WHERE Id = {minionId}";
            using (SqlCommand command = new SqlCommand(nameAndAge , connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine($"{reader[0]} – {reader[1]} years old");
                    }
                    
                }

            }

            connection.Close();
        }
    }
}

