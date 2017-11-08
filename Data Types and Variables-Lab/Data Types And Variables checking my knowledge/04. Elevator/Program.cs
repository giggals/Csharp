using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            int capacityOfElevator = int.Parse(Console.ReadLine());

            int coursesNeeded = 0;

            if (numberOfPeople % capacityOfElevator == 0)
            {
                coursesNeeded = numberOfPeople / capacityOfElevator;
            }
            else
            {
                coursesNeeded = numberOfPeople / capacityOfElevator + 1;
            }

            Console.WriteLine(coursesNeeded);

        }
    }
}
