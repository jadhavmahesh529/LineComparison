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


        }
    }
}