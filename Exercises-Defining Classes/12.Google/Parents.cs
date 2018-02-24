using System;
using System.Collections.Generic;
using System.Text;


public class Parents
{
    private string parentName;

    public string ParentName
    {
        get { return parentName; }
        set { parentName = value; }
    }

    private DateTime parentBirthday;

    public DateTime ParentBirthday
    {
        get { return parentBirthday; }
        set { parentBirthday = value; }
    }
    
    public Parents(string parentName , DateTime parentBirthday)
    {
        this.ParentName = parentName;
        this.ParentBirthday = parentBirthday;
    }

}

