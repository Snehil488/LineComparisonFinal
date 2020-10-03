using System;

namespace LineComparisonFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Line Comparison Computation.");
            Line line = new Line();
            for (int numOfLines = 0; numOfLines < 2; numOfLines++)
            {
                line.lineLength[numOfLines] = line.CalculateLength();
            }
            line.CompareLength(line.lineLength[0], line.lineLength[1]);
        }
    }
}
