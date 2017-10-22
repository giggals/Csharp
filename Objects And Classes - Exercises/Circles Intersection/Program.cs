using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CircleIntersection
{
    public class Circle
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Radius { get; set; }
    }
    public class Program
    {
        static void Main()
        {
            string[] firstCircleInput = Console.ReadLine().Split(' ');
            string[] secondCircleInput = Console.ReadLine().Split(' ');

            

            Circle firstCircle = new Circle();
            firstCircle.Radius = double.Parse(firstCircleInput[2]);
            firstCircle.X = double.Parse(firstCircleInput[0]);
            firstCircle.Y = double.Parse(firstCircleInput[1]);
         

            Circle secondCircle = new Circle();
            secondCircle.Radius = double.Parse(secondCircleInput[2]);
            secondCircle.X = double.Parse(secondCircleInput[0]);
            secondCircle.Y = double.Parse(secondCircleInput[1]);

            bool circlesIntersect = Intersect(firstCircle, secondCircle);
            if (circlesIntersect)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }


        }

        static public bool Intersect(Circle firstCircle, Circle secondCircle)
        {
           
            double deltaX = Math.Abs(firstCircle.X - secondCircle.X);
            double deltaY = Math.Abs(firstCircle.Y - secondCircle.Y);
            double distance = Math.Sqrt(Math.Pow(deltaX, 2) + Math.Pow(deltaY, 2));
            double sumRadiuses = firstCircle.Radius + secondCircle.Radius;
           
            if (sumRadiuses >= distance)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}