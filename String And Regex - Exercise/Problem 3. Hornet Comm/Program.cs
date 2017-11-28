using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Problem_3.Hornet_Comm
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string privateMessage = @"^([0-9]+) <-> ([A-Za-z0-9]+)$";
            string broadcastregex = @"^([^0-9]+) <-> ([A-Za-z0-9]+)$";

            List<string> message = new List<string>();
            List<string> broadcast = new List<string>();

           
           
            while (input != "Hornet is Green")
            {
                Match privateMatches = Regex.Match(input, privateMessage);
                Match broadcastMatches = Regex.Match(input, broadcastregex);


                if (privateMatches.Success)
                {
                    string reversed = privateMatches.Groups[1].ToString();
                    reversed = String.Join("",reversed.ToCharArray().Reverse().ToArray());
                    message.Add(reversed + " ->" + " " + privateMatches.Groups[2].ToString());
                }
                if (broadcastMatches.Success)
                {
                    string frequency = broadcastMatches.Groups[2].ToString();
                    string frequencyResult = "";

                    for (int i = 0; i < frequency.Length; i++)
                    {
                        if (char.IsLower(frequency[i]))
                        {
                            frequencyResult = frequencyResult + char.ToUpper(frequency[i]);
                        }
                        else if (char.IsUpper(frequency[i]))
                        {
                            frequencyResult = frequencyResult + char.ToLower(frequency[i]);
                        }
                        else
                        {
                            frequencyResult = frequencyResult + (frequency[i].ToString());
                        }
                    }
                    broadcast.Add(frequencyResult + " ->" + " " + broadcastMatches.Groups[1]);
                }
                input = Console.ReadLine();
            }


            Console.WriteLine("Broadcasts:");
            if (broadcast.Count == 0)
            {
                Console.WriteLine("None");
            }
            else
            {
                broadcast.ForEach(e => Console.WriteLine(e));
            }
                

            Console.WriteLine("Messages:");
            if (message.Count == 0)
            {
                Console.WriteLine("None");
            }
            else
            {
                message.ForEach(e => Console.WriteLine(e));
            }
        }
        
    }
}
