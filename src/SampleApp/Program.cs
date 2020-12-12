using System;
using System.Collections.Generic;
using System.Linq;
using FluentAssertions;

namespace SampleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            SetPassword("cAr1");
            Authorize(223691457).Should().Be(true);
            Authorize(303580761).Should().Be(true);
        }

        private static bool Authorize(int v)
        {
            return hashes.Contains(v);
        }

        static int modNum = 1000000007;

        static int[] p =
        {
            1,
131,
17161,
2248091,
294499921,
579489385,
913108910,
617266377,
861894827,
908221553,
        };

        private static HashSet<long> hashes = new HashSet<long>();

        private static void SetPassword(string v)
        {
            hashes.Add(MakeHash(v));
            var b = MakeHash(new string(v.Concat("0").ToArray()));

            foreach (long item in characters)
            {
                hashes.Add(b + item - '0');
            }
        }

        static string characters = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";


        static long MakeHash(string v)
        {
            long hash = 0;
            for (int i = 0; i < v.Length; i++)
            {
                hash += (long)v[i] * p[v.Length - i - 1];

            }

            return hash % modNum;
        }

    }
}
