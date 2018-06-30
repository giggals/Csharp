using System;
using System.Data.SqlClient;

class Program
{
    static void Main(string[] args)
    {
        using (SqlConnection connection = new SqlConnection(Configuration.ConnectionString))
        {
            connection.Open();

            int villandId = int.Parse(Console.ReadLine());
            
            string nameAndAgeForMinon = $"SELECT m.Name , m.Age FROM Villains AS v JOIN MinionsVillains AS mv ON mv.VillainId = v.Id   JOIN Minions AS m ON m.Id = mv.MinionId WHERE v.Id = {villandId}";

            string villanName = $"SELECT Name FROM Villains WHERE Id = {villandId}";

            using (SqlCommand command = new SqlCommand(villanName , connection))
            {
                if (command.ExecuteScalar() == null)
                {
                    Console.WriteLine($"No villain with ID {villandId} exists in the database.");
                    Environment.Exit(0);
                }

                Console.WriteLine($"Villain: {command.ExecuteScalar()}");
            }
            

            using (SqlCommand command = new SqlCommand(nameAndAgeForMinon , connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (!reader.HasRows)
                    {
                        Console.WriteLine($"Villain: {villanName} (no minions)");
                    }
                    int counter = 1;
                    while (reader.Read())
                    {
                        Console.WriteLine($"{counter}. {reader[0]} {reader[1]}");
                        counter++;
                    }
                }
            }


            connection.Close();
        }
    }
}

