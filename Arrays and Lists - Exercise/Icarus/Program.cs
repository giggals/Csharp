using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Icarus
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int startingPostion = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();

            int damage = 1;

            while (input != "Supernova")
            {
                string[] commands = input.Split();
                string direction = commands[0];
                int steps = int.Parse(commands[1]);

                input = Console.ReadLine();

                switch (direction)
                {
                    case "left":
                        for (int i = 0; i < steps; i++)
                        {
                            if (startingPostion == 0)
                            {
                               startingPostion = numbers.Length - 1;
                                damage++;
                                numbers[startingPostion] = numbers[startingPostion] - damage;
                                continue;
                            }
                            startingPostion--;
                            numbers[startingPostion] = numbers[startingPostion] - damage;
                           

                        }
                        break;
                    case "right":
                        for (int i = 0; i < steps; i++)
                        {
                            if (startingPostion == numbers.Length - 1)
                            {
                                startingPostion = 0;
                                damage++;
                                numbers[startingPostion] = numbers[startingPostion] - damage;
                                continue;
                            }
                            startingPostion++;
                            numbers[startingPostion] = numbers[startingPostion] - damage;
                            
                        }
                        break;
                }
            }
            Console.WriteLine(string.Join(" ",numbers));
        }
        
    }
}
