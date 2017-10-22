using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advertisment_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            
            string[] phrases = new string[6];
            phrases[0] = "Excellent product.";
            phrases[1] = "Such a great product.";
            phrases[2] = "I always use that product.";
            phrases[3] = "I can’t live without this product.";
            phrases[4] = "Exceptional product.";
            phrases[5] = "Best product of its category.";



            string[] events = new string[6];
            events[0] = "Now I feel good.";
            events[1] = "I have succeeded with this product.";
            events[2] = "Makes miracles. I am happy of the results!";
            events[3] = "I cannot believe but now I feel awesome.";
            events[4] = "Try it yourself, I am very satisfied.";
            events[5] = "I feel great!";




            string[] authors = new string[8];
            authors[0] = "Diana";
            authors[1] = "Petya";
            authors[2] = "Stella";
            authors[3] = "Elena";
            authors[4] = "Katya";
            authors[5] = "Iva";
            authors[6] = "Annie";
            authors[7] = "Eva";




            string[] cities = new string[5];
            cities[0] = "Burgas";
            cities[1] = "Sofia";
            cities[2] = "Plovdiv";
            cities[3] = "Varna";
            cities[4] = "Ruse";

            Random rand = new Random();

            string readingPhrases = phrases[rand.Next(0, phrases.Length)];
            string readingEvents = events[rand.Next(0, events.Length)];
            string readingAuthors = authors[rand.Next(0, authors.Length)];
            string readingCities = cities[rand.Next(0, cities.Length)];

            for (int i = 0; i < input; i++)
            {
                Console.WriteLine($"{readingPhrases} {readingEvents} {readingAuthors} - {readingCities}");
            }
            
        }
        
    }

    
        
}
