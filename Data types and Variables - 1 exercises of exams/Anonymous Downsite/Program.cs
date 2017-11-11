using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfWebsites = int.Parse(Console.ReadLine());
            int securityKey = int.Parse(Console.ReadLine());

            decimal totalLoss = 0;

            BigInteger powered = 1;

            for (int i = 0; i < numberOfWebsites; i++)
            {
                string[] websitesData = Console.ReadLine().Split();
                string siteName = websitesData[0];
                long siteVisists = long.Parse( websitesData[1]);
                decimal pricePerVisit = decimal.Parse(websitesData[2]);

                decimal siteLoss = siteVisists * pricePerVisit;
                totalLoss += siteLoss;

                Console.WriteLine(siteName);

            }

            Console.WriteLine($"Total Loss: {totalLoss:F20}");

            for (int i = 0; i < numberOfWebsites; i++)
            {
                powered *= securityKey;
            }

            Console.WriteLine($"Security Token: {powered}");

        }
    }
}
