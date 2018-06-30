using System;
using System.Data.SqlClient;

class Program
{
    static void Main(string[] args)
    {
        string[] minionInfo = Console.ReadLine().Split(new char[] { ' ', ':' }, StringSplitOptions.RemoveEmptyEntries);
        string[] villanInfo = Console.ReadLine().Split(new char[] { ' ', ':' }, StringSplitOptions.RemoveEmptyEntries);

        string minionName = minionInfo[1];
        int minionAge = int.Parse(minionInfo[2]);
        string town = minionInfo[3];

        string villanName = villanInfo[1];

        string townSql = $"SELECT Name FROM Towns WHERE Name = '{town}'";

        using (SqlConnection connection = new SqlConnection(Configuration.ConnectionString))
        {
            connection.Open();

            using (SqlCommand command = new SqlCommand(townSql, connection))
            {
                if (command.ExecuteScalar() == null)
                {
                    string townInsertSql = $"INSERT INTO Towns (Name) VALUES ('{town}')";

                    using (SqlCommand commandForInsert = new SqlCommand(townInsertSql, connection))
                    {
                        commandForInsert.ExecuteNonQuery();
                    }

                    Console.WriteLine($"Town {town} was added to the database.");
                }
            }

            string villainName = $"SELECT Name FROM Villains WHERE Name = '{villanName}'";

            using (SqlCommand command = new SqlCommand(villainName, connection))
            {
                if (command.ExecuteScalar() == null)
                {
                    string villainInsertSql = $"INSERT INTO  Villains (Name, EvilnessFactorId) VALUES ('{villanName}',4)";

                    using (SqlCommand commandForInsert = new SqlCommand(villainInsertSql, connection))
                    {
                        commandForInsert.ExecuteNonQuery();
                    }
                    
                }
            }

            string findVillainId = $"SELECT Id From Villains WHERE Name = '{villanName}'";

            string findMinionId = $"SELECT Id From Minions WHERE Name = '{minionName}'";

          

            using (SqlCommand command = new SqlCommand(findVillainId, connection))
            {
                var vilanId = command.ExecuteScalar();

                using (SqlCommand minionIdCommand = new SqlCommand(findMinionId, connection))
                {
                    var minionId = minionIdCommand.ExecuteScalar();


                    string insertIntoMinoinsVillainsSql = $"INSERT INTO MinionsVillains (MinionId , VillainId) VALUES ({minionId},{vilanId})";

                    using (SqlCommand insertMinionToHisVillain = new SqlCommand(insertIntoMinoinsVillainsSql, connection))
                    {

                        Console.WriteLine(insertMinionToHisVillain.ExecuteScalar());
                    }

                }
                
            }


            connection.Close();
        }


    }
}

