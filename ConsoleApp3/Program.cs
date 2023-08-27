using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Program
    {
        static void Main(string[] args)
        {
            Fibonacci fibonacci = new Fibonacci();
            Average average = new Average();

            Console.Write("Derinlik giriniz!");
            int depth = int.Parse(Console.ReadLine());

            int[] series = fibonacci.CalculateFibonacci(depth);
            double series_average = average.CalculateAverage(series);
            Console.Write("Fibonacci serisnin ortalaması:" + series_average);

            Console.ReadKey();
        }
    }
}
