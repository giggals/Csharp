using System;
using System.Collections.Generic;
using System.Text;


public class Human
{
    private const int firstNameMinLenght = 4;
    private const int secondNameMinLenght = 3;


    private string firstName;
    private string secondName;

    public string FirstName
    {

        set
        {
            FristNameValidation(value, nameof(firstName));
            this.firstName = value;
        }
    }

    private void FristNameValidation(string value, string type)
    {
        if (char.IsLower(value[0]))
        {
            throw new ArgumentException($"Expected upper case letter! Argument: firstName");
        }

        if (value.Length < firstNameMinLenght)
        {
            throw new ArgumentException($"Expected length at least 4 symbols! Argument: lastName");
        }

    }

    private string SecondName
    {
        get { return this.secondName; }
        set
        {
            SeondNamevalidation(value , nameof(secondName));
            this.secondName = value;

        }
    }

    private static void SeondNamevalidation(string value , string type)
    {
        if (char.IsLower(value[0]))
        {
            throw new ArgumentException($"Expected upper case letter! Argument: firstName");
        }
        if (value.Length < secondNameMinLenght)
        {
            throw new ArgumentException($"Expected length at least 3 symbols! Argument: lastName");
        }
    }

    public Human(string firstName, string secondName)
    {
        this.FirstName = firstName;
        this.SecondName = secondName;
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"First Name: {this.firstName}")
                .AppendLine($"Last Name: {this.secondName}");

        return sb.ToString();

    }


}

