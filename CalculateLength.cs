using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
    internal class CalculateLength
    {
        public void calculatelength()
        {
            Console.WriteLine("Enter the coordinates of Point x1:");
            double x1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the coordinates of Point y1:");
            double y1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the coordinates of Point x2:");
            double x2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the coordinates of Point y2:");
            double y2 = Convert.ToDouble(Console.ReadLine());


            double length = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            Console.WriteLine($"The length of the line is: {length}");
        }
    }
}
