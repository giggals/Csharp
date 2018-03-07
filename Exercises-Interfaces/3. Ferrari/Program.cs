using System;


class Program
{
    static void Main(string[] args)
    {
        string name = Console.ReadLine();

        ICar ferrari = new Ferrari(name);

        Console.WriteLine(ferrari);
    }
}

