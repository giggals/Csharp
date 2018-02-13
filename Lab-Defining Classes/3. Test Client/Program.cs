using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
       
        Dictionary<int, BankAccount> accounts = new Dictionary<int, BankAccount>();

        string command;

        while ((command = Console.ReadLine()) != "End")
        {
            var commandArg = command.Split();
            int accountId = int.Parse(commandArg[1]);

            switch (commandArg[0])
            {
                case "Create":
                    if (accounts.ContainsKey(accountId))
                    {
                        Console.WriteLine("Account already exists");
                    }
                    else
                    {
                        var acc = new BankAccount();
                        acc.Id = accountId;
                        accounts.Add(accountId, acc);
                    }
                    break;
                case "Deposit":

                    if (Exist(accountId, accounts))
                    {
                        accounts[accountId].Deposit(int.Parse(commandArg[2]));
                    }

                    break;
                case "Withdraw":
                    if (Exist(accountId, accounts))
                    {
                        accounts[accountId].Withdraw(int.Parse(commandArg[2]));
                    }

                    break;
                case "Print":
                    if (Exist(accountId, accounts))
                    {
                        Console.WriteLine(accounts[accountId]);
                    }

                    break;

            }
        }

    }

    static bool Exist(int accountId, Dictionary<int, BankAccount> accounts)
    {
        if (accounts.ContainsKey(accountId))
        {
            return true;
        }
        else
        {
            Console.WriteLine("Account does not exist");
            return false;
        }

    }
}

