using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search_For_A_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            var commands = Console.ReadLine().Split().Select(int.Parse).ToList();
            var numsYouHaveToTake = commands[0];
            var numsYouHaveToDelete = commands[1];
            var numThatMustBeInList = commands[2];

            var hasNumber = nums
                .Take(numsYouHaveToTake)
                .Skip(numsYouHaveToDelete)
                .Any(x => x == numThatMustBeInList);

            Console.WriteLine(hasNumber ? "YES!" : "NO!");
        }
    }
}
