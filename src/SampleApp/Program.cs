using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;
using FluentAssertions;

class Result
{
    

    /*
     * Complete the 'getWays' function below.
     *
     * The function is expected to return a LONG_INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. LONG_INTEGER_ARRAY c
     */

    public static long getWays(int n, List<long> c)
    {
        var calculated = new bool[]

        Mod = (int i, long make) =>
        {
            if (make == 0)
                return 1;
            if (make < 0)
                return 0;
            if (i >= c.Count)
                return 0;

            return Mod(i, make - c[i]) + Mod(i + 1, make);
        };

        return Mod(0, n);
    }

    public static Func<int, long, int> Mod { get; private set; }

}

class Solution
{
    public static void Main(string[] args)
    {

        Result.getWays(4,new List<long> { 1, 2, 3 }).Should().Be(4);

    }
}
