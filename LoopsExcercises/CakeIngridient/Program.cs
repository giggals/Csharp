using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeIngridient
{
    class Program
    {
        static void Main(string[] args)
        {
            string ingridients = "";
            int numberOFIngridients = 0;


            for (int i = 0; i <= 20; i++)
            {

                ingridients = Console.ReadLine();

                if (ingridients == "Bake!")
                {
                    break;
                }
                Console.WriteLine($"Adding ingredient {ingridients }.");
                numberOFIngridients++;
               
            }
            if (ingridients == "Bake!")
            {
                Console.WriteLine($"Preparing cake with {numberOFIngridients } ingredients.");
            }
            






        }
    }
}
