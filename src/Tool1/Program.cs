using System;
using System.Numerics;

namespace Tool1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(BigInteger.ModPow(new BigInteger(131), new BigInteger(i), 1000000007) );
            }
        }
    }
}
