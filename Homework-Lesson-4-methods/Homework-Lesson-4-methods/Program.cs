using System;

namespace Work
{
    class Program
    {
        static void Main()
        {
            double x, y;
            Console.Write("Enter your first number : ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter your second number : ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter your string : ");
            string str = Console.ReadLine();
            Console.Write("Enter count review : ");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(MAX(x, y));
            Console.WriteLine(MIN(x, y));
            Console.WriteLine(Repeat(str, N));
            Console.Write(TrySumIfOdd(x, y));

        }

        static double MAX(double a, double b)
        {
            if (a > b)
            {
                Console.Write("MAX : ");
                return a;
            }
            else
            {
                Console.Write("MAX : ");
                return b;
            }
        }
        static double MIN(double a, double b, double c)
        {
            if (a < b && a < c)
            {
                Console.Write("MIN : ");
                return a;
            }
            else if (b < c && b < a)
            {
                Console.Write("MIN : ");
                return b;
            }
            else
            {
                Console.Write("MIN : ");
                return c;
            }
        }
        static double MIN(double a, double b, double c, double d)
        {
            if (a < b && a < c && a < d)
            {
                Console.Write("MIN : ");
                return a;
            }
            else if (b < c && b < a && b < d)
            {
                Console.Write("MIN : ");
                return b;
            }
            else if (d < a && d < b && d < c)
            {
                Console.Write("MIN : ");
                return d;
            }
            else
            {
                Console.Write("MIN : ");
                return c;
            }
        }
        static double MAX(double a, double b, double c)
        {
            if (a > b && a > c)
            {
                Console.Write("MAX : ");
                return a;
            }
            else if (b > c && b > a)
            {
                Console.Write("MAX : ");
                return b;
            }
            else
            {
                Console.Write("MAX : ");
                return c;
            }
        }
        static double MAX(double a, double b, double c, double d)
        {
            if (a > b && a > c && a > d)
            {
                Console.Write("MAX : ");
                return a;
            }
            else if (b > c && b > a && b > d)
            {
                Console.Write("MAX : ");
                return b;
            }
            else if (d > a && d > b && d > c)
            {
                Console.Write("MAX : ");
                return d;
            }
            else
            {
                Console.Write("MAX : ");
                return c;
            }
        }

        static double MIN(double a, double b)
        {
            if (a < b)
            {
                Console.Write("MIN : ");
                return a;
            }
            else
            {
                Console.Write("MIN : ");
                return b;
            }
        }
        static double TrySumIfOdd(double a, double b)
        {
            if ((a + b) % 2 != 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        static string Repeat(string str, int N)
        {
            string new_STR = "";
            for (int i = 0; i < N; i++)
            {
                new_STR += str;
            }
            return new_STR;
        }
    }
}