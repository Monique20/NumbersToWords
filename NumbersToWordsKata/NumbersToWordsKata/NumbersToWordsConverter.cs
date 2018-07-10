using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersToWordsKata
{
    public class NumbersToWordsConverter
    {
        public string Convert(int input)
        {
            var Units = GetUnitsDictionary();
            foreach (KeyValuePair<int, string> item in Units)
            {
                if (item.Key == input)
                {
                    return item.Value;
                }
            }

            var Tens = GetTensDictionary();
            foreach (KeyValuePair<int, string> item in Tens)
            {
                if (item.Key == input)
                {
                    return item.Value;
                }
            }

            var Teens = GetTeenDictionary();
            foreach (KeyValuePair<int, string> item in Teens)
            {
                if (item.Key == input)
                {
                    return item.Value;
                }
            }
            return null;

        }

        private static Dictionary<int, string> GetTeenDictionary()
        {
            Dictionary<int, string> Teens = new Dictionary<int, string>();
            Teens.Add(11, "eleven");
            Teens.Add(12, "twelve");
            Teens.Add(13, "thirteen");
            Teens.Add(14, "fourteen");
            Teens.Add(15, "fifteen");
            Teens.Add(16, "sixteen");
            Teens.Add(17, "seventeen");
            Teens.Add(18, "eighteen");
            Teens.Add(19, "nineteen");
            return Teens;
        }

        private static Dictionary<int, string> GetTensDictionary()
        {
            Dictionary<int, string> Tens = new Dictionary<int, string>();
            Tens.Add(10, "ten");
            Tens.Add(20, "twenty");
            Tens.Add(30, "thirty");
            Tens.Add(40, "forty");
            Tens.Add(50, "fifty");
            Tens.Add(60, "sixty");
            Tens.Add(70, "seventy");
            Tens.Add(80, "eighty");
            Tens.Add(90, "ninety");
            return Tens;
        }

        private static Dictionary<int, string> GetUnitsDictionary()
        {
            Dictionary<int, string> Units = new Dictionary<int, string>();
            Units.Add(0, "zero");
            Units.Add(1, "one");
            Units.Add(2, "two");
            Units.Add(3, "three");
            Units.Add(4, "four");
            Units.Add(5, "five");
            Units.Add(6, "six");
            Units.Add(7, "seven");
            Units.Add(8, "eight");
            Units.Add(9, "nine");
            return Units;
        }
    }
}
