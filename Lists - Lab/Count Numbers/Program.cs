using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            nums.Sort();
            int count = 1;


            for (int i = 1; i <= nums.Count; i++)
            {
                if (i == nums.Count)
                {
                    Console.WriteLine("{0} -> {1}", nums[nums.Count - 1], 1);
                    break;
                }
                if (nums[i] == nums[i - 1])
                {
                    count++;
                    if (i == nums.Count - 1)
                    {
                        Console.WriteLine("{0} -> {1}", nums[i - 1], count);
                        count = 1;
                        break;

                    }
                }
                else
                {
                    Console.WriteLine("{0} -> {1}", nums[i - 1], count);
                    count = 1;
                }
            }



        }
    }
}