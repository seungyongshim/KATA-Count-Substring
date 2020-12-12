using System;
using System.Numerics;
using FluentAssertions;

namespace SampleApp
{
    class Program
    {
        static BigInteger fibonacciModified(int t1, int t2, int n)
        {
            var t = new BigInteger[n];

            t[0] = new BigInteger(t1);
            t[1] = new BigInteger(t2);

            for (int i = 2; i < n; i++)
            {
                t[i] = t[i - 2] + BigInteger.Pow(t[i - 1], 2);
            }

            return t[n - 1];
        }

        static void Main(string[] args)
        {
            var ret = fibonacciModified(1, 1, 20);
        }
    }
}
