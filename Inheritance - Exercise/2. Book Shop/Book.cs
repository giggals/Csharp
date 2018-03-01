using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq;


public class Book
{
    private string title;
    private string author;
    private decimal price;

    public virtual string Title
    {
        get { return title; }
        set
        {
            if (value.Length < 3)
            {
                throw new ArgumentException("Title not valid!");
            }
            title = value;
        }
    }

    public virtual string Author
    {
        get { return author; }
        set
        {
            string[] names = value.Split(" ");
            var indexOf = value.IndexOf(' ');

            if (names.Length > 1)
            {
                if (char.IsDigit(value[indexOf + 1]))
                {
                    throw new ArgumentException("Author not valid!");
                }
            }
           
            author = value;
        }
    }


    public virtual decimal Price
    {
        get { return price; }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Price not valid!");
            }
            price = value;
        }
    }

    public Book(string author, string title, decimal price)
    {
        this.Author = author;
        this.Title = title;
        this.Price = price;
    }

    public override string ToString()
    {
        StringBuilder resultBuilder = new StringBuilder();
        resultBuilder.AppendLine($"Type: {this.GetType().Name}");
        resultBuilder.AppendLine($"Title: {this.Title}");
        resultBuilder.AppendLine($"Author: {this.Author}");
        resultBuilder.AppendLine($"Price: {this.Price:f2}");

        string result = resultBuilder.ToString().TrimEnd();
        return result;
    }

}

