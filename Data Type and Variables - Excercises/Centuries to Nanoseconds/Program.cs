using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centuries_to_Nanoseconds
{
    class Program
    {
        static void Main(string[] args)
        {
            byte centuries = byte.Parse(Console.ReadLine());
            int  years = centuries * 100;
            int  days = (int) (years * 365.2422);
            decimal hours = days * 24m;
            decimal minutes = hours * 60m;
            decimal seconds = minutes * 60m; 
            decimal  miliSeconds = seconds * 1000m;
            decimal microSeconds = miliSeconds * 1000m;
            decimal nanoSeconds = microSeconds * 1000m;

            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {miliSeconds} milliseconds = " +
                $"{microSeconds} microseconds = {nanoSeconds} nanoseconds");
            
            

            
            
            
                
            

            
            
        }
    }
}
