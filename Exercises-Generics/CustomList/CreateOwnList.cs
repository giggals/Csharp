using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;


public class CustomList<T> : IEnumerable<T> where T : IComparable<T>

{
    public T[] list;

    public CustomList()
    {
        this.list = new T[0];
    }

    public T this[int index]
    {
        get
        {
            return this.list[index];
        }
        set
        {
            this.list[index] = value;

        }
    }

    public int Lenght => this.list.Length;

    public int Count { get; private set; }
    
    public void Add(T element)
    {
        this.Count++;

        if (this.Count > this.Lenght)
        {
            T[] newList = new T[2 * this.Count];
            Array.Copy(this.list, newList, this.Lenght);
            this.list = newList;
        }

        this.list[this.Count - 1] = element;

    }

    public T Remove(int index)
    {
        this.Count--;

        for (int i = index; i < this.Count; i++)
        {
            list[i] = list[i + 1];
        }

        this.list[this.Count] = default(T);

        return this.list[index];
    }

    public bool Contains(T element)
    {
        for (int i = 0; i < this.Count; i++)
        {
            if (list[i].Equals(element))
            {
                return true;
            }
        }

        return false;
    }

    public void Swap(int index1, int index2)
    {
        var firstElement = list[index1];

        list[index1] = list[index2];
        list[index2] = firstElement;
    }

    public  int CountGreaterThan(T element)
    {
        int counter = 0;

        for (int i = 0; i < this.Count; i++)
        {
            if (list[i].CompareTo(element) > 0)
            {
                counter++;
            }
        }

        return counter;
    }

    public T Max()
    {
        var max = list[0];

        for (int i = 1; i < this.Count; i++)
        {
            if (list[i].CompareTo(max) > 0)
            {
                max = list[i];
            }
        }

        return max;
    }

    public T Min()
    {
        var min = list[0];

        for (int i = 1; i < this.Count; i++)
        {
            if (list[i].CompareTo(min) < 0)
            {
                min = list[i];
            }
        }

        return min;
    }

    public void Sort()
    {
        Array.Sort(list ,0 ,this.Count);
    }

    public IEnumerator<T> GetEnumerator()
    {
        for (int i = 0; i < this.Count; i++)
        {
            yield return this.list[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
