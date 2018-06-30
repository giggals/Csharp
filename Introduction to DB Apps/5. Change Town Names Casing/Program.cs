using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string country = Console.ReadLine();

        int countryCode = 0;

        switch (country)
        {
            case "Bulgaria":
                countryCode = 1;
                break;
            case "England":
                countryCode = 2;
                break;
            case "Cyprus":
                countryCode = 3;
                break;
            case "Germany":
                countryCode = 4;
                break;
            case "Norway":
                countryCode = 5;
                break;
        }

        string countOfTowns = $"SELECT COUNT(*) FROM Towns WHERE CountryCode = {countryCode}";

        string upperCaseTowns = $"UPDATE Towns SET Name = UPPER(Name) WHERE CountryCode = {countryCode}";


        using (SqlConnection connection = new SqlConnection(Configuration.ConnectionString))
        {
            connection.Open();

            using (SqlCommand command = new SqlCommand(countOfTowns,connection))
            {
                if ((int)command.ExecuteScalar() == 0)
                {
                    Console.WriteLine("No town names were affected.");
                }
                else
                {
                    Console.WriteLine($"{command.ExecuteScalar()} town names were affected.");

                    using (SqlCommand updateToUpperCase = new SqlCommand(upperCaseTowns , connection))
                    {
                        updateToUpperCase.ExecuteNonQuery();

                        string printNames = $"SELECT Name FROM Towns WHERE CountryCode = {countryCode}";

                        using (SqlCommand sqlPrintTowns = new SqlCommand(printNames , connection))
                        {
                            using (SqlDataReader reader = sqlPrintTowns.ExecuteReader())
                            {
                                List<string> namesOfTowns = new List<string>();

                                while (reader.Read())
                                {
                                    namesOfTowns.Add((string)reader[0]);
                                }

                                Console.WriteLine(string.Join(", " , namesOfTowns));
                            }
                        }
                        
                    }

                }
              
            }
            
            connection.Close();
        }

    }
}

