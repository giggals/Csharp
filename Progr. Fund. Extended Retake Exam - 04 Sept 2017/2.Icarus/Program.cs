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

            int[] sequence = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int startingPostion = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int damage = 1;

            while (input != "Supernova")
            {
                string[] command = input.Split();
                string direction = command[0];
                int index = int.Parse(command[1]);

                input = Console.ReadLine();

                switch (direction)
                {
                    case "left":
                        for (int i = 0; i < index; i++)
                        {

                            if (startingPostion == 0)
                            {
                                startingPostion = sequence.Length - 1;
                                damage++;
                                sequence[startingPostion] = sequence[startingPostion] - damage;
                                continue;
                            }
                            startingPostion--;
                            sequence[startingPostion] = sequence[startingPostion] - damage;
                        }
                        break;


                    case "right":
                        for (int i = 0; i < index; i++)
                        {


                            if (startingPostion == sequence.Length - 1)
                            {
                                startingPostion = 0;
                                damage++;
                                sequence[startingPostion] = sequence[startingPostion] - damage;
                                continue;
                            }
                            startingPostion++;
                            sequence[startingPostion] = sequence[startingPostion] - damage;
                        }
                        break;
                }

            }

            Console.WriteLine(string.Join(" ", sequence));

        }
    }
}
