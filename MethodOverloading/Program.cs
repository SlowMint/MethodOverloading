using System;

namespace MethodOverloading
{
    class Program
    {
        public static void Main(string[] args)
        {
            int a = 22;
            int b = 32;

            int answer = Add(a, b);

            decimal c = 22.2m;
            decimal d = 33.3m;

            decimal decimalAnswer = Add(c, d);

            var cash = Add(3, 4, true);

            Console.WriteLine($"int add: {answer} decimal add: {decimalAnswer}");
            Console.WriteLine(cash);
        }
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static decimal Add(decimal c, decimal d)
        {
            return c + d;
        }

        public static string Add(int a, int b, bool isTrue)
        {
            var sum = a + b;

            if (isTrue == true && sum > 1)
            {
                return $"${sum} dollars";

            }
            else if (isTrue == true && sum == 1)
            {
                return $"${sum} dollar";
            }
            else if (isTrue == true && sum < 1)
            {
                return $"${sum} dollar";
            }
            else
            {
                return sum.ToString();
            }

        }
    }
}