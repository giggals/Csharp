using System;
using System.Linq;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        string[] phoneInput = Console.ReadLine().Split(" ");

        string Webpattern = @"[0-9]+";
        string phonePattern = @"[^0-9]+";

        
        for (int i = 0; i < phoneInput.Length; i++)
        {
            if (Regex.IsMatch(phoneInput[i] , phonePattern))
            {
                Console.WriteLine("Invalid number!");
                continue;
            }

            Smartphone smartphone = new Smartphone();
            smartphone.PrintPhoneNumber(phoneInput[i]);
        }

        string[] browseInput = Console.ReadLine().Split(" ");
       

        for (int i = 0; i < browseInput.Length; i++)
        {
            if (Regex.IsMatch(browseInput[i],Webpattern))
            {
                Console.WriteLine("Invalid URL!");
                continue;
            }
          
            Smartphone browse = new Smartphone();
            browse.PrintBrowese(browseInput[i]);
        }

    }
}

