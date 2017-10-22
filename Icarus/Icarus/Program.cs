using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mentor_Group
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] plane = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int startingPosition = int.Parse(Console.ReadLine());
            int currentPostion = startingPosition;

            int damage = 1;
            var stepsMade = 0;

            string[] command = Console.ReadLine().Split(' ');
            var direction = command[0];
            int steps = int.Parse(command[1]);


            while (direction != "Supernova")
            {
                if (direction == "left")
                {
                    for (int i = currentPostion - 1; i <= -1; i--)
                    {
                        if (stepsMade == steps)
                        {
                            break;
                        }
                        if (i != 1)
                        {
                            currentPostion = i;
                        }
                        else
                        {
                            i = plane.Length - 1;
                            damage++;
                            currentPostion = plane.Length - 1;
                        }
                        plane[i] = plane[i] - damage;
                        stepsMade++;
                    }
                    stepsMade = 0;

                }
                else if (direction == "right")
                {
                    for (int i = currentPostion + 1; i <= plane.Length; i++)
                    {
                        if (stepsMade == steps)
                        {
                            break;
                        }
                        if (i != plane.Length)
                        {
                            currentPostion = 1;
                        }
                        else
                        {
                            damage++;
                            i = 0;
                            currentPostion = 0;
                        }
                        plane[i] = plane[i] - damage;
                        stepsMade++;
                    }
                    stepsMade = 0;
                }
                command = Console.ReadLine().Split(' ');
                direction = command[0];
            }
            Console.WriteLine(String.Join((" "), plane));
        }
    }
}
