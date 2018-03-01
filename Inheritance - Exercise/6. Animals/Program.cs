using System;


class Program
{
    static void Main(string[] args)
    {
        string type = string.Empty;

        try
        {
            while ((type = Console.ReadLine()) != "Beast!")
            {
                GetAnimalType(type);
            }
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
        
    }

    private static void GetAnimalType(string type)
    {
        try
        {
            string[] parseCommand = Console.ReadLine().Split(" ");
            string name = parseCommand[0];
            int age = int.Parse(parseCommand[1]);
            string gender = parseCommand[2];

            switch (type)
            {
                case "Dog":
                    Animals dog = new Dog(name, age, gender);
                    Console.WriteLine("Dog");
                    Console.WriteLine(dog.GetResult());
                    break;
                case "Cat":
                    Animals cat = new Cat(name, age, gender);
                    Console.WriteLine("Cat");
                    Console.WriteLine(cat.GetResult());
                    break;
                case "Frog":
                    Animals frog = new Frog(name, age, gender);
                    Console.WriteLine("Frog");
                    Console.WriteLine(frog.GetResult());
                    break;
                case "Kitten":
                    Animals kitten = new Kittens(name, age, gender);
                    Console.WriteLine("Kitten");
                    Console.WriteLine(kitten.GetResult());
                    break;
                case "Tomcat":
                    Animals tomcat = new Tomcat(name, age, gender);
                    Console.WriteLine("Tomcat");
                    Console.WriteLine(tomcat.GetResult());
                    break;
                default:
                    throw new ArgumentException("Invalid input!");
            }
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
        
    }
}

