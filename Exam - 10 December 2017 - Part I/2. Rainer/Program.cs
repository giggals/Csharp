using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Rainer
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sequence = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> oldValues = new List<int>(sequence);

            int nextIndex = sequence[sequence.Count - 1];
            sequence.RemoveAt(sequence.Count - 1);

            bool exit = false;
            
            int steps = 0;
            while (!exit)
            {
                for (int i = 0; i < sequence.Count; i++)
                {
                    sequence[i]--;
                    
                }
                for (int i = 0; i < sequence.Count; i++)
                {
                   
                    if (sequence[i] == 0 && i == nextIndex)
                    {
                        exit = true;
                        break;
                    }
                }

                if (exit)
                {
                    break;
                }

                for (int i = 0; i < sequence.Count; i++)
                {
                    if (sequence[i] == 0)
                    {
                        sequence[i] = oldValues[i];
                    }
                    
                }
                
                steps++;
                
                nextIndex = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(string.Join(" ",sequence));
            Console.WriteLine(steps);
        }
    }
}
