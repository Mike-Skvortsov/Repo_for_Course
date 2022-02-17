using System;

namespace Homework_Lesson_3_Loops
{
	class Program
	{
		static void Main()
		{
            //Task 2
            bool Validity;
            string number;
            Console.Write("Hi, enter your first number: ");
            number = Console.ReadLine();
            Validity = int.TryParse(number, out int X);
            if (Validity == false)
            {
                Console.WriteLine("Invalid input");
                return;
            }
            Console.Write("Hi, enter your second number: ");
            number = Console.ReadLine();
            Validity = int.TryParse(number, out int Y);
            if (Validity == false)
            {
                Console.WriteLine("Invalid input");
                return;
            }
            int sum = 0;
            if (X == Y)
            {
                Console.WriteLine(X);
                return;
            }
            if (X < Y)
            {
                for (int i = X; i <= Y; i++)
                {
                    sum += i;
                }
            }
            else if (Y < X)
            {
                for (int i = Y; i <= X; i++)
                {
                    sum += i;
                }
            }

            Console.Write(sum);
            //Task 1
            //const int a = 10;
            //const int b = 13;
            //if (a == b)
            //{
            //    Console.Write(a);
            //    return;
            //}
            //for (int i = 0; i <= b; i++)
            //{
            //    sum += i;
            //    if(a==i)
            //    {
            //        Console.Write(sum);
            //        return;
            //    }
            //}
        }
    }
	}
