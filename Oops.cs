using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
    internal class Oops
    {
        public interface ILengthCalculate
        {
            double CalculateLength();
        }

        public class Point
        {
            public double X { get; set; }
            public double Y { get; set; }

            public Point(double x, double y)
            {
                X = x;
                Y = y;
            }
        }

        public class Line : ILengthCalculate
        {
            public Point Point1 { get; set; }
            public Point Point2 { get; set; }

            public Line(Point point1, Point point2)
            {
                Point1 = point1;
                Point2 = point2;
            }

            public double CalculateLength()
            {
                double length = Math.Sqrt(Math.Pow(Point2.X - Point1.X, 2) + Math.Pow(Point2.Y - Point1.Y, 2));
                return length;
            }
            public void CheckEquality(Line Line2)
            {
                bool areEqual = Point1.X == Line2.Point1.X && Point1.Y == Line2.Point1.Y && Point2.X == Line2.Point2.X && Point2.Y == Line2.Point2.Y;

                Console.WriteLine("Lines are" + (areEqual ? " " : " not ") + "equal.");
            }
            public void CompareLines(Line Line2)
            {
                double length1 = CalculateLength();
                double length2 = Line2.CalculateLength();

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

        }
    }
}
