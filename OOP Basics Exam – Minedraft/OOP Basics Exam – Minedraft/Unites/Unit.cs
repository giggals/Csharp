using System;
using System.Collections.Generic;
using System.Text;


public abstract class Unit
{
    private string id;

    public string Id
    {
        get { return id; }
        set { id = value; }
    }

    protected Unit(string id)
    {
        this.Id = id;
    }

    public string ConvertedType(string name)
    {
        var result = string.Empty;
        int index = 0;
        string firstPart = string.Empty;
        for (int i = 0; i < name.Length; i++)
        {
            if (char.IsUpper(name[i]) && i > 0)
            {
                index = i;
                break;
            }
            firstPart += name[i];
        }

        result = firstPart + " " + name.Substring(index);

        return result;
    }

}

