using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

public class Student : Human
{
    private string facultyNumber;


    public Student(string firstName, string secondName, string facultyNumber)
       : base(firstName, secondName)
    {
        this.FacultuNumber = facultyNumber;
    }


    public string FacultuNumber
    {
        get { return facultyNumber; }
        set
        {
            if (value.Length < 5 || value.Length > 10 || !(value.All(char.IsLetterOrDigit)))
            {
                throw new ArgumentException("Invalid faculty number!");
            }

            this.facultyNumber = value;

        }
    }



    public override string ToString()
    {
        StringBuilder resultStr = new StringBuilder(base.ToString());

        resultStr.AppendLine($"Faculty number: {this.FacultuNumber}");

        var result = resultStr.ToString().TrimEnd();
        return result;
    }

}

