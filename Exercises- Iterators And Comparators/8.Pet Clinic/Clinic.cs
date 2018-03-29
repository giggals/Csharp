
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Text;

public class Clinic
{
    private Pet[] Pets;

    public string Name { get; set; }

    public int Rooms { get; set; }

    private int Center => this.Pets.Length / 2;

    public bool HasEmptyRooms => this.Pets.Any(x => x == null);
    

    public Clinic(string name, int rooms)
    {
        this.Name = name;

        ValidateRooms(rooms);
        this.Rooms = rooms;
        this.Pets = new Pet[rooms];

    }

    private void ValidateRooms(int rooms)
    {
        if (rooms % 2 == 0)
        {
            throw new InvalidOperationException("Invalid Operation!");
        }
    }

    public bool Add(Pet pet)
    {
        int currentRoom = this.Center;

        for (int i = 0; i < this.Pets.Length; i++)
        {
            if (i % 2 != 0)
            {
                currentRoom -= i;
            }
            else
            {
                currentRoom += i;
            }

            if (this.Pets[currentRoom] == null)
            {
                this.Pets[currentRoom] = pet;
                return true;
            }

        }

        return false;
    }

    public bool Release()
    {
        for (int i = 0; i < this.Pets.Length; i++)
        {
            int index = (this.Center + i) % this.Pets.Length;

            if (this.Pets[index] != null)
            {
                this.Pets[index] = null;
                return true;
            }
        }

        return false;
    }

    public void Print(int index)
    {
        Console.WriteLine(
        this.Pets[index - 1]?.ToString() ?? "Room empty");
        
    }

    public void PrintAll()
    {
        
        for (int i = 1; i <= this.Pets.Length; i++)
        {
            Print(i);
        }
    }

}
