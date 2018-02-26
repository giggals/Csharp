using System;


class Program
{
    static void Main(string[] args)
    {
        
        double lenghth = double.Parse(Console.ReadLine());
        double width = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());
        Box box = new Box(lenghth, width, height);

        Console.WriteLine(box);
    }

}

