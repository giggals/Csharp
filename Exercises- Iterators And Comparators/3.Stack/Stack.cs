
using System;
using System.Collections;
using System.Collections.Generic;

public class Stack<T> : IEnumerable<T>
{
    private List<T> List;

    public Stack(params T[] list)
    {
        this.List = new List<T>();
    }
    
    public void Push(params T[] elements)
    {
        
        for (int i = 0; i < elements.Length; i++)
        {
            this.List.Add(elements[i]);
        }
    }

    public void Pop()
    {
        if (this.List.Count == 0)
        {
            throw new ArgumentException("No elements");
        }
       
        this.List.RemoveAt(List.Count - 1);
    }

    public IEnumerator<T> GetEnumerator()
    {
        for (int i = this.List.Count- 1; i >= 0; i--)
        {
           yield return this.List[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
