using System;
using System.Collections.Generic;

namespace q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<double> hash = new HashSet<double>();
            for (int i = 2; i <= 100; i++)
            {
                for (int j = 2; j <= 100; j++)
                {
                    double temp = Math.Pow(i, j);
                    hash.Add(temp);
                }
            }

            Console.WriteLine(hash.Count);
            Console.ReadKey();
        }
    }
}
