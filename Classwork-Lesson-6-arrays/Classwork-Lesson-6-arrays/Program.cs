using System;

namespace lesson_6_arrays
{
    class Program
    {
        static void Main()
        {

            const int N = 10;
            int[] array = new int[N];
            //int[] array1 = new[] { 1, 2, 3, 4, 5 };
            int[] array2 = { 12, 23, 34, 45, 56 };
            for (int i = 0; i < N; i++)
            {
                array[i] = i;
            }
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine($"{i} item of array is {array[i]}");
            }


            Console.WriteLine("_________   ________");

            int multiplayer = 2;

            MultipleByNumber(array, multiplayer);
            var copiedArray = Copy(array);
            Console.WriteLine("____________________");

            foreach (int el in copiedArray)
            {
                Console.WriteLine($"item of array is {el}");
            }
            Console.WriteLine("____________________");
            foreach (var el in InitArray(12, 20))
            {
                Console.WriteLine($"item of array is {el}");
            }
            Console.WriteLine("____________________");

            var random = new Random();
            int[] randomArray = new int[N];
            for (int i = 0; i < N; i++)
            {
                randomArray[i] = random.Next();
            }

            foreach (var el in randomArray)
            {
                Console.WriteLine($"item of array is {el}");
            }

            Console.WriteLine("____________________");

            foreach (var el in Sort(randomArray))
            {
                Console.WriteLine($"item of array is {el}");
            }
        }

        static int[] Sort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[i + 1] = temp;
                    }
                }
            }
            return array;
        }


        static int[] InitArray(int a, int b)
        {
            int[] init = new int[b - a];
            for (int i = 0; i < init.Length; i++)
            {
                init[i] = a++;
            }
            return init;
        }

        static int[] Copy(int[] array)
        {
            int[] copy = new int[array.Length];
            int k = 0;
            foreach (int el in array)
            {
                copy[k++] = el;
            }
            return copy;
        }
        static int[] MultipleByNumber(int[] array, int multiplayer)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] *= multiplayer;
            }
            return array;
        }
    }
}