using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



    
           


namespace _8_Calories
    {
        class Program
        {
            static void Main()
            {
                int n = int.Parse(Console.ReadLine());
                int calls = 0;
                for (int i = 0; i < n; i++)
                {
                    string ingr = Console.ReadLine().ToLower();

                    if (ingr == "tomato sauce")
                    {
                        calls = calls + 150;
                    }
                    if (ingr == "cheese")
                    {
                        calls = calls + 500;
                    }
                    if (ingr == "salami")
                    {
                        calls = calls + 600;
                    }
                    if (ingr == "pepper")
                    {
                        calls = calls + 50;
                    }
                }
                Console.WriteLine("Total calories: " + calls);
            }
        }
    }



    