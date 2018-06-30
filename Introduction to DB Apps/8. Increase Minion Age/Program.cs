using System;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int[] minionsIds = Console.ReadLine().Split().Select(int.Parse).ToArray();

        using (SqlConnection connection = new SqlConnection(Configuration.ConnectionString))
        {
            connection.Open();
            

            for (int i = 0; i < minionsIds.Length; i++)
            {
                string updateAge = $"UPDATE Minions SET Age += 1 WHERE Id = {minionsIds[i]}";

                using (SqlCommand command = new SqlCommand(updateAge , connection))
                {
                    command.ExecuteNonQuery();
                }

                string nameAndAge = $"SELECT Name, Age FROM Minions WHERE Id = {minionsIds[i]}";

                using (SqlCommand printNameAndAge = new SqlCommand(nameAndAge , connection))
                {
                    using (SqlDataReader reader = printNameAndAge.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string titleCase = CultureInfo.CurrentCulture.TextInfo.ToTitleCase($"{reader[0]} {reader[1]}");
                            Console.WriteLine(titleCase);
                        }
                    }
                }

            }
            

            connection.Close();
        }

      

    }
}

