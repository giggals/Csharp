
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;

public class Box<T> where T : IComparable<T>
{
    private  List<T> Values { get; }

    public Box()
    {
        this.Values = new List<T>();
    }

    public void AddToList(T value)
    {
        this.Values.Add(value);
    }

    public void Replace(int firstIndex, int secondIndex)
    {
        var swapper = this.Values[firstIndex];
        var swappingWith = this.Values[secondIndex];

        this.Values[firstIndex] = swappingWith;
        this.Values[secondIndex] = swapper;
    }

    public int CountMethod(T chekItem)
    {
        int counter = 0;
        foreach (var item in Values)
        {
            if (item.CompareTo(chekItem) > 0)
            {
                counter++;
            }
            
        }

        return counter;
    }

    public override string ToString()
    {
        var result = string.Empty;

        foreach (var item in Values)
        {
            result += $"{item.GetType().FullName}: {item}" + Environment.NewLine;
        }


        return result.TrimEnd();
    }
}
