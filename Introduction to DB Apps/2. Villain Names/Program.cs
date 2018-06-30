using System;
using System.Data.SqlClient;
using System.Linq;


class Program
{
    static void Main(string[] args)
    {

        using (SqlConnection connection = new SqlConnection(Configuration.ConnectionString))
        {
            connection.Open();
            
            string villainNamesAndTheirMinions = "SELECT  v.Name , COUNT(mv.MinionId) AS [Count] FROM Villains AS v JOIN MinionsVillains AS mv ON mv.VillainId = v.Id GROUP BY v.Name HAVING COUNT(mv.MinionId) >= 3 ORDER BY [Count] DESC";

            using (SqlCommand command = new SqlCommand(villainNamesAndTheirMinions, connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine($"{reader[0]} - {reader[1]}");
                    }
                }
            }
            
            connection.Close();
        }
    }
}

