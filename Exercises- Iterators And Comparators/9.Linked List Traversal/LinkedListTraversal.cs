
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class LinkedListTraversal<T> : IEnumerable<T>
{
    private List<T> list;

    public LinkedListTraversal()
    {
        this.list = new List<T>();
    }


    public void Add(T element)
    {
        this.Count++;

        this.list.Add(element);
    }

    public bool Remove(T element)
    {
        if (this.list.Contains(element))
        {
            this.list.Remove(element);
            this.Count--;
            return true;
        }

        return false;
    }

    public int Count;

    public IEnumerator<T> GetEnumerator()
    {
        for (int i = 0; i < list.Count; i++)
        {
            yield return list[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        throw new System.NotImplementedException();
    }
}
