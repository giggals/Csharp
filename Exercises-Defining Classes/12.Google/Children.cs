using System;
using System.Collections.Generic;
using System.Text;


public class Children
{
    private string childName;

    public string ChildName
    {
        get { return childName; }
        set { childName = value; }
    }

    private DateTime childBirthday;     

    public DateTime ChildBirthday
    {
        get { return childBirthday; }
        set { childBirthday = value; }
    }

    public Children(string childName , DateTime chiledBirthday)
    {
        this.ChildName = childName;
        this.ChildBirthday = childBirthday;
    }

}

