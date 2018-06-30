using System;
using System.Data.SqlClient;

class Program
{
    static void Main(string[] args)
    {
        int villainId = int.Parse(Console.ReadLine());

        string findVillainName = $"SELECT Name FROM Villains WHERE Id = {villainId}";

        string deleteVillain = $"DELETE FROM MinionsVillains WHERE VillainId = {villainId} DELETE FROM Villains WHERE Id = {villainId}";

        using (SqlConnection connection = new SqlConnection(Configuration.ConnectionString))
        {
            connection.Open();

            using (SqlCommand command = new SqlCommand(findVillainName , connection))
            {
                if (command.ExecuteScalar() == null)
                {
                    Console.WriteLine("No such villain was found.");
                }
                else
                {
                    using (SqlCommand deleteVillainAndRealieasMininons = new SqlCommand(deleteVillain , connection))
                    {
                        Console.WriteLine($"{command.ExecuteScalar()} was deleted.");
                        Console.WriteLine($"{deleteVillainAndRealieasMininons.ExecuteNonQuery()} minions were released.");
                    }
                }
            }



            connection.Close();
        }

    }
}
