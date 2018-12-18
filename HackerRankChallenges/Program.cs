using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HackerRankChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(dayOfProgrammer(2400));
            //Staircase(10);
            //var bill = new List<int>() { 3, 10, 2, 9 };
            //bonAppetit(bill, 1, 7);

            //int[] ar = new int[] { 1, 1, 3, 1, 2, 1, 3, 3, 3, 3 };
            //Console.WriteLine(sockMerchant(10, ar));

            //Console.WriteLine(pageCount(7, 4));
            //countingValleys(12, "DDUUDDUDUUUD");

            //var keyboards = new int[] { 4 };
            //var drives = new int[] { 5 };
            //getMoneySpent(keyboards, drives, 5);

            //Console.WriteLine(catAndMouse(1, 3, 2));
            int[][] s = new int[][]
            {
            new int [] { 4, 9, 2 },
            new int [] { 3, 5 ,7 },
            new int [] { 8 ,1 ,5 }
            };
            formingMagicSquare(s);

            Console.ReadLine();
        }
        static string dayOfProgrammer(int year)
        {
            string dayOfProgrammer = "";
            dayOfProgrammer = year == 1918
                                ? "26.09.1918"
                : ((year <= 1917) && (year % 4 == 0)) || ((year % 400 == 0) || (year % 4 == 0)) && (year % 100 != 0) || ((year > 1917) && (DateTime.IsLeapYear(year)))
                    ? $"12.09.{year}"
                    : $"13.09.{year}";

            return dayOfProgrammer;
        }

        static void Staircase(int num)
        {
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine(new String('#', i + 1).PadLeft(num, ' '));
            }
        }

        static void bonAppetit(List<int> bill, int k, int b)
        {
            int anaDontPay = bill[k];
            int anaPaid = b;
            int anaHaveToPay = ((bill.Sum() - anaDontPay)) / 2;
            var chargeAmount = anaPaid - anaHaveToPay;
            var msg = chargeAmount > 0 ? chargeAmount.ToString() : "Bon Appetit";
            Console.WriteLine(msg);
        }

        static int sockMerchant(int n, int[] ar)
        {
            return ar.GroupBy(l => l)
                         .Select(lg =>
                               new
                               {
                                   Num = lg.Key,
                                   Quant = lg.Count(),
                                   QuantPairs = lg.Count() % 2 == 0 ? lg.Count() / 2 : (int)Math.Abs(Convert.ToDecimal(lg.Count() / 2))
                               }.QuantPairs).Sum();
        }

        static int pageCount(int n, int p)
        {
            const int FIRSTPAGE = 1;
            int startPage = n - p <= p - FIRSTPAGE ? n : FIRSTPAGE;

            var i = startPage > p ? startPage - p : p - startPage;

            return startPage != n
                ? i > 1
                    ? startPage == FIRSTPAGE
                        ? (int)Math.Ceiling(Convert.ToDouble(i) / 2)
                        : i / 2
                    : i
                : i == 1 && n % 2 == 0
                    ? i
                    : i / 2;
        }

        static int countingValleys(int n, string s)
        {
            var path = s.ToCharArray();
            int valley = 0;
            int atualLevel = 0;
            int temp = 0;

            for (int i = 0; i < path.Length; i++)
            {
                temp = path[i] == 'D' ? atualLevel - 1 : atualLevel + 1;
                valley = atualLevel < 0 && temp == 0 ? valley + 1 : valley;
                atualLevel = temp;
            }

            return valley;
        }

        static int getMoneySpent(int[] keyboards, int[] drives, int b)
        {
            int temp = 0;
            int moneySpent = 0;
            for (int j = 0; j < keyboards.Length; j++)
            {
                for (int i = 0; i < drives.Length; i++)
                {
                    temp = keyboards[j] + drives[i];
                    moneySpent = moneySpent < temp && temp < b
                        ? temp
                        : -1;
                }
            }
            return moneySpent;
        }

        static string catAndMouse(int x, int y, int z)
        {
            return Math.Abs(x - z) < Math.Abs(y - z)
                ? "Cat A"
                : Math.Abs(x - z) == Math.Abs(y - z)
                    ? "Mouse C"
                    : "Cat B";
        }

        static int formingMagicSquare(int[][] s)
        {

            return 0;
        }
    }
}
