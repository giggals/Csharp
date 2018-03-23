using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

public class Box<T>
{
    private readonly List<T> items;

    public Box()
    {
        this.items = new List<T>();
    }

    public void Add(T elememnt)
    {
        this.items.Add(elememnt);
    }

    public T Remove()
    {
        var removeEl = this.items.Last();

        items.RemoveAt(this.items.Count - 1);

        return removeEl;
    }

    public int Count => this.items.Count();
}

