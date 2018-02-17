using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int numberOfInputs = int.Parse(Console.ReadLine());
        Rectangle rectangle = new Rectangle(input[0],input[1],input[2],input[3]);
     
        for (int i = 0; i < numberOfInputs; i++)
        {
            int[] pointArgs = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int x = pointArgs[0];
            int y = pointArgs[1];

            Point point = new Point(x,y);
          
            Console.WriteLine(rectangle.Contains(point));
        }
        
    }
}

