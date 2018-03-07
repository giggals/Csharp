using System;
using System.Collections.Generic;
using System.Text;


public class Smartphone : ICallable , IBrowse
{
    public string PhoneNumber { get; private set; }
    public string WebSite { get; private set; }
    
   
    
    public void PrintPhoneNumber(string phone)
    {
        Console.WriteLine($"Calling... {phone}");
    }

    public void PrintBrowese(string website)
    {
        Console.WriteLine($"Browsing: {website}!");
    }
}

