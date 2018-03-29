using System;
using System.Collections.Generic;



public class PersonNameComparer : IComparer<Person>
{
    public int Compare(Person x, Person y)
    {
        var result = x.Name.Length.CompareTo(y.Name.Length);

        if (result == 0)
        {
            var firstPerson = char.ToLower(x.Name[0]);
            var secondPerson = char.ToLower(y.Name[0]);

            result = firstPerson.CompareTo(secondPerson);

        }

        return result;
        
    }
}
