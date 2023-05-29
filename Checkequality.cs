using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
    internal class Checkequality
    {
        public void checkequality()
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


            bool areEqual = x1Line1 == x1Line2 && y1Line1 == y1Line2 && x2Line1 == x2Line2 && y2Line1 == y2Line2;

            Console.WriteLine("Lines are" + (areEqual ? " " : " not ") + "equal.");
        }
    }
}
