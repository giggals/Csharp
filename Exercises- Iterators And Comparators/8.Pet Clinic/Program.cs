using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Runtime.CompilerServices;


class Program
{
    static void Main(string[] args)
    {
        int numberOfPets = int.Parse(Console.ReadLine());

        List<Clinic> clinics = new List<Clinic>();
        List<Pet> pets = new List<Pet>();

        for (int i = 0; i < numberOfPets; i++)
        {
            string[] commandArgs = Console.ReadLine().Split();

            switch (commandArgs[0])
            {

                case "Create":
                    try
                    {
                        if (commandArgs[1] == "Pet")
                        {
                            string name = commandArgs[2];
                            int age = int.Parse(commandArgs[3]);
                            string kind = commandArgs[4];

                            Pet pet = new Pet(name, age, kind);
                            pets.Add(pet);
                        }
                        else
                        {
                            string name = commandArgs[2];
                            int rooms = int.Parse(commandArgs[3]);

                            Clinic clinic = new Clinic(name, rooms);
                            clinics.Add(clinic);
                        }
                    }
                    catch (InvalidOperationException e)
                    {
                        Console.WriteLine(e.Message);

                    }
                    
                    break;
                case "Add":
                    string petName = commandArgs[1];
                    string clinicsName = commandArgs[2];

                    Pet petToAdd = pets.FirstOrDefault(x => x.Name == petName);
                    Clinic clinicToAdd = clinics.FirstOrDefault(c => c.Name == clinicsName);

                    Console.WriteLine(
                    clinicToAdd.Add(petToAdd));
                    break;
                case "Release":
                    string clinicRealease = commandArgs[1];
                    Clinic clinicToRemove = clinics.FirstOrDefault(c => c.Name == clinicRealease);

                    Console.WriteLine(
                    clinicToRemove.Release());
                    break;
                case "HasEmptyRooms":
                    string clinicName = commandArgs[1];
                    Clinic clinictoChek = clinics.FirstOrDefault(c => c.Name == clinicName);

                    Console.WriteLine(clinictoChek.HasEmptyRooms);  
                    break;
                case "Print":
                    if (commandArgs.Length == 3)
                    {
                        string nameOfClinic = commandArgs[1];
                        int room = int.Parse(commandArgs[2]);

                        Clinic clinictoPrint = clinics.FirstOrDefault(c => c.Name == nameOfClinic);

                       
                        clinictoPrint.Print(room);
                    }
                    else
                    {
                        string nameofCl = commandArgs[1];
                        Clinic clinictoPrint = clinics.FirstOrDefault(c => c.Name == nameofCl);

                        clinictoPrint.PrintAll();

                    }
                    break;
            }
        }



    }
}


