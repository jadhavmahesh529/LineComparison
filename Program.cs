using static LineComparison.Oops;

namespace LineComparison
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Welcome to Line Comparison Computation Program");
            CalculateLength calculator = new CalculateLength();
            calculator.calculatelength();

            Checkequality equalityChecker = new Checkequality();
            equalityChecker.checkequality();

            Comparetwolines comparetwolines = new Comparetwolines();
            comparetwolines.comparetwolines();

            Console.WriteLine("Enter the coordinates of the endpoints for Line 1:");
            double point1Line1 = Convert.ToDouble(Console.ReadLine());
            double point2Line1 = Convert.ToDouble(Console.ReadLine());
            double point3Line1 = Convert.ToDouble(Console.ReadLine());
            double point4Line1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the coordinates of the endpoints for Line 2:");
            double point1Line2 = Convert.ToDouble(Console.ReadLine());
            double point2Line2 = Convert.ToDouble(Console.ReadLine());
            double point3Line2 = Convert.ToDouble(Console.ReadLine());
            double point4Line2 = Convert.ToDouble(Console.ReadLine());

            Point point1 = new Point(point1Line1, point2Line1);
            Point point2 = new Point(point3Line1, point4Line1);
            Point point3 = new Point(point1Line2, point2Line2);
            Point point4 = new Point(point3Line2, point4Line2);

            Line line1 = new Line(point1, point2);
            Line line2 = new Line(point3, point4);

            double length1 = line1.CalculateLength();
            double length2 = line2.CalculateLength();

            Console.WriteLine("Line 1 Length: " + length1);
            Console.WriteLine("Line 2 Length: " + length2);

            line1.CheckEquality(line2);

            line1.CompareLines(line2);

        }
    }
}