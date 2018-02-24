using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        var n = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        var rectangles = new Rectangle[n[0]];

        for (int i = 0; i < n[0]; i++)
        {
            string[] commandInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string name = commandInput[0];
            int width = int.Parse(commandInput[1]);
            int height = int.Parse(commandInput[2]);
            int topLeftHorizoontal = int.Parse(commandInput[3]);
            int topLeftVertical = int.Parse(commandInput[4]);
            
             rectangles[i] = new Rectangle(name,width,height,topLeftHorizoontal,topLeftVertical);

        }

        for (int i = 0; i < n[1]; i++)
        {
            string[] chekRectangles = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            var firstRect = rectangles.First(x => x.ID == chekRectangles[0]);

            var secondRect = rectangles.First(x => x.ID == chekRectangles[1]);

            if (firstRect.ChekRectangle(secondRect))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
            
        }
       
    }
}

