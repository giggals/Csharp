using System;
using System.Collections.Generic;
using System.Data.SqlClient;

class Program
{
    static void Main(string[] args)
    {
        string minionNames = "SELECT Name FROM Minions";

        using (SqlConnection connection = new SqlConnection(Configuration.ConnectionString))
        {
            connection.Open();

            using (SqlCommand command = new SqlCommand(minionNames, connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    List<string> names = new List<string>();

                    while (reader.Read())
                    {
                        names.Add((string)reader[0]);
                    }

                    int decrease = 1;
                   

                    for (int i = 0; i <= names.Count / 2; i++)
                    {
                        if (i == names.Count / 2)
                        {
                            Console.WriteLine(names[i]);
                            continue;
                        }
                        Console.WriteLine(names[i]);
                        Console.WriteLine(names[names.Count - decrease++]);
                    }
                }
            }
            
            connection.Close();
        }
    }
}

