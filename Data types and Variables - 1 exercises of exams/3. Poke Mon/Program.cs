using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            int pokePower = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            byte exhaustionFactor = byte.Parse(Console.ReadLine());

            int counter = 0;
            double fiftypercent = pokePower * 0.5;

            while (pokePower >= distance)
            {
                 pokePower = pokePower - distance;
                counter++;

                if (pokePower == fiftypercent)
                {
                    if (exhaustionFactor != 0)
                    {
                        pokePower = pokePower / exhaustionFactor;
                    }
                    
                }
               
            }

            if (pokePower < distance)
            {
                Console.WriteLine(pokePower);
                Console.WriteLine(counter);
            }

           
            
        }
    }
}
