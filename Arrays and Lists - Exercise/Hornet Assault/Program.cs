using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hornet_Assault
{
    class Program
    {
        static void Main(string[] args)
        {
             int[] beeHives = Console.ReadLine().Split().Select(int.Parse).ToArray();
            List<int> hornets = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> result = new List<int>();

            int hornetPower = hornets.Sum();

            for (int i = 0; i < beeHives.Length; i++)
            {
                if (beeHives[i] >= hornetPower)
                {
                    int removedEl = hornets[0];
                    hornets.Remove(0);
                   result.Add(beeHives[i] - hornetPower);
                    hornetPower -= removedEl;
                }
                else if (hornetPower > beeHives[i])
                {
                   result.Add()
                }
            }
            Console.WriteLine(string.Join(" ",result));
        }

      
    }
}
