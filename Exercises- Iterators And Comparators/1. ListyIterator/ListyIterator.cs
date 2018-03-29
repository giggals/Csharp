
using System;
using System.Collections;
using System.Collections.Generic;

public class ListyIterator<T> : IEnumerable<T>
{

    private IList<T> List { get; set; }

    public int currentIndex { get; set; }

    public ListyIterator()
    {
        this.currentIndex = 0;
    }

    public void Create(params T[] list)
    {
        this.List = new List<T>(list);
    }

    public bool Move()
    {
        if (this.currentIndex + 1 < this.List.Count)
        {
            this.currentIndex++;
            return true;
        }

        return false;
    }

    public bool HasNext()
    {
        if (this.currentIndex == this.List.Count - 1)
        {
            return false;
        }

        return true;
    }

    public void Print()
    {
        if (this.List.Count == 0)
        {
            throw new InvalidOperationException("Invalid Operation!");
        }

        Console.WriteLine(this.List[currentIndex]);
    }

    public void PrintAll()
    {
        Console.WriteLine(
        string.Join(" ", this.List));
    }

    public IEnumerator<T> GetEnumerator()
    {
        for (int i = 0; i < List.Count; i++)
        {
            yield return this.List[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}

