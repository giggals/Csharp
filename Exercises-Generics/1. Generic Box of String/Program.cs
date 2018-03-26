using System;
using System.Linq;


public class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        Box<double> box = new Box<double>();

        for (int i = 0; i < n; i++)
        {
            var command = double.Parse(Console.ReadLine());
            box.AddToList(command);
        }

        double compareString = double.Parse(Console.ReadLine());

       
        Console.WriteLine(box.CountMethod(compareString));
    }
}

