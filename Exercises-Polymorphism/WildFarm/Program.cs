using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Animals> animals = new List<Animals>();

        string command = string.Empty;

        int counter = 0;
        while ((command = Console.ReadLine()) != "End")
        {
            string[] commandArgs = command.Split();

            if (counter % 2 == 0)
            {
                switch (commandArgs[0])
                {
                    case "Owl":
                        Bird owl = new Owl(commandArgs[1], double.Parse(commandArgs[2]), double.Parse(commandArgs[3]));
                        animals.Add(owl);
                        break;
                    case "Hen":
                        Bird hen = new Hen(commandArgs[1], double.Parse(commandArgs[2]), double.Parse(commandArgs[3]));
                        animals.Add(hen);
                        break;
                    case "Mouse":
                        string name = commandArgs[1];
                        double weight = double.Parse(commandArgs[2]);
                        string livingPlace = commandArgs[3];
                        Mammal mouse = new Mouse(name, weight, livingPlace);
                        animals.Add(mouse);
                        break;
                    case "Dog":
                        Mammal dog = new Dog(commandArgs[1], double.Parse(commandArgs[2]), commandArgs[3]);
                        animals.Add(dog);
                        break;
                    case "Cat":
                        Feline cat = new Cat(commandArgs[1], double.Parse(commandArgs[2]), commandArgs[3], commandArgs[4]);
                        animals.Add(cat);
                        break;
                    case "Tiger":
                        Feline tiger = new Tiger(commandArgs[1], double.Parse(commandArgs[2]), commandArgs[3], commandArgs[4]);
                        animals.Add(tiger);
                        break;

                }
            }
            else if (counter % 2 != 0)
            {
                GiveFoodToAnimals(animals, commandArgs);
            }

            counter++;
        }

        foreach (var animal in animals)
        {
            Console.WriteLine(animal);
        }
    }

    private static void GiveFoodToAnimals(List<Animals> animals, string[] commandArgs)
    {
        string foodType = commandArgs[0];
        int quantity = int.Parse(commandArgs[1]);
        var currentAnimal = animals[animals.Count - 1];
        Console.WriteLine(currentAnimal.MakeSound());


        currentAnimal.Eat(foodType, quantity);
        
    }
    
}

