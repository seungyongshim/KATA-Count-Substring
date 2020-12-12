using System;
using System.Linq;
using FluentAssertions;


namespace SampleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var ret = CountSubString("ababa", "aba");

            ret.Should().Be(5);
        }

        private static int CountSubString(string ori, string sub)
        {
            var count = 0;

            SubMatch(0, 0);

            return count;


            void SubMatch(int oriPos, int subPos)
            {
                if (subPos >= sub.Length)
                {
                    count++;
                    return;
                }

                if (oriPos >= ori.Length) return ;
                

                if(ori[oriPos] == sub[subPos])
                {
                    for (int i = oriPos + 1; i < ori.Length + 1; i++)
                    {
                        SubMatch(i, subPos + 1);
                    }
                }
                return ;
            }


            return 0;
        }
    }
}
