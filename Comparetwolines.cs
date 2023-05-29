using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
    internal class Comparetwolines
    {
        public void comparetwolines()
        {
            Console.WriteLine("Enter the coordinates of the endpoints for Line 1:");
            double x1Line1 = Convert.ToDouble(Console.ReadLine());
            double y1Line1 = Convert.ToDouble(Console.ReadLine());
            double x2Line1 = Convert.ToDouble(Console.ReadLine());
            double y2Line1 = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Enter the coordinates of the endpoints for Line 2:");
            double x1Line2 = Convert.ToDouble(Console.ReadLine());
            double y1Line2 = Convert.ToDouble(Console.ReadLine());
            double x2Line2 = Convert.ToDouble(Console.ReadLine());
            double y2Line2 = Convert.ToDouble(Console.ReadLine());


            double length1 = CalculateLength(x1Line1, y1Line1, x2Line1, y2Line1);
            double length2 = CalculateLength(x1Line2, y1Line2, x2Line2, y2Line2);


            int comparison = length1.CompareTo(length2);

            if (comparison == 0)
            {
                Console.WriteLine("Both lines are equal in length.");
            }
            else if (comparison > 0)
            {
                Console.WriteLine("Line 1 is greater in length than Line 2.");
            }
            else
            {
                Console.WriteLine("Line 1 is less in length than Line 2.");
            }
        }

        static double CalculateLength(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }

    }
}
