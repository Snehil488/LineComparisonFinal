using System;

namespace LineComparisonFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Line Comparison Computation.");
            Line line = new Line();
            double[] lineLength = new double[2];
            for (int numOfLines = 0; numOfLines < 2; numOfLines++)
            {
                lineLength[numOfLines] = line.calculateLength();
            }
            line.compareLength(lineLength[0], lineLength[1]);
        }
    }
}
