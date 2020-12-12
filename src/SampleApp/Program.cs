using System;
using System.Collections.Generic;
using System.Linq;
using FluentAssertions;

namespace SampleApp
{
    class Program
    {
        static List<int> Prices;

        public static long stockmax(List<int> prices)
        {
            Prices = prices;

            var ret = BuyOfsell(0, prices.Count - 1, 0, prices.Last());

            return ret;
        }

        static long BuyOfsell(long stocks, int day, long money, int max)
        {
            if (day == -1)
            {
                money += stocks * max;
                return money;
            }

            // 최대값이 바뀌면 다 판다.
            if (max <= Prices[day])
            {
                money += stocks * max;
                max = Prices[day];
                stocks = 0;
            }
            else
            {
                money -= Prices[day];
                stocks++;
            }

            
            var c = BuyOfsell(stocks , day - 1, money , max);

            return c;
        }

        static void Main(string[] args)
        {
            stockmax(new List<int> { 4,3,2 }).Should().Be(0);
        }
    }
}
