using System;
using System.Collections.Generic;
using FluentAssertions;

namespace SampleApp
{
    class Program
    {
        static List<int> Prices;

        public static long stockmax(List<int> prices)
        {
            Prices = prices;

            var ret = BuyOfsell(0, 0, 0);

            return ret;
        }

        static long BuyOfsell(int stocks, int day, long money)
        {
            if (day >= Prices.Count)
            {
                return money;
            }
            // 1주 사거나
            var a = BuyOfsell(stocks + 1, day + 1, money - Prices[day]);

            // 팔거나
            var b = BuyOfsell(0, day + 1, money + Prices[day] * stocks);

            // 거래하지 않거나
            var c = BuyOfsell(stocks , day + 1, money - Prices[day]);

            return Math.Max(a, Math.Max(b, c));
        }

        static void Main(string[] args)
        {
            stockmax(new List<int> { 1, 2, 100 }).Should().Be(197);
        }
    }
}
