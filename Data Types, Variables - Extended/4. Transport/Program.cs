using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Transport
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int capacity = 4 + 8 + 12;
            int courses = 0;

            if (people < capacity)
            {
                courses = 1;
            }
            if (people % capacity == 0)
            {
                courses = people / capacity;
            }
             if (people % capacity != 0)
            {
                courses = people / capacity + 1;
            }
             
            Console.WriteLine(courses);

        }
    }
}
