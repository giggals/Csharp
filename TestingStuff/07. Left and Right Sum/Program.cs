using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Left_and_Right_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputs = int.Parse(Console.ReadLine());

            int leftsum = 0;
            int rightsum = 0;

            for (int i = 0; i < inputs; i++)
            {
                int leftnumbres = int.Parse(Console.ReadLine());

                leftsum = leftsum + leftnumbres;
            }

            for (int i = 0; i < inputs; i++)
            {
                int rightnumbers = int.Parse(Console.ReadLine());

                rightsum = rightsum + rightnumbers;
            }

            if (leftsum == rightsum)
            {
                Console.WriteLine($"Yes, sum = {leftsum} ");
            }
            else
            {
                Console.WriteLine($"No, diff ={Math.Abs(rightsum - leftsum)}");
            }
        }
    }
}
