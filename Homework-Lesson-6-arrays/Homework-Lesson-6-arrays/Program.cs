using System;

namespace Homework_Lesson_6_arrays
{
	class Program
	{

		// Bubble Sort
		static void Main()
		{
			const int N = 4;
			int[] array = new int[N] { 2, 44, 84, 1 };
			SortBubble(array, N);
			foreach (var item in array)
			{
				Console.Write(item + "\t");
			}
			Console.Write("\n_________________________\n");
			int[] array2 = new int[N] { 204, 445, 84, 1111 };
			SortInsertion(array2, N);
			foreach (var item in array2)
			{
				Console.Write(item + "\t");
			}
			Console.Write("\n_________________________\n");
			int[] array3 = new int[8] { 27, 3, 5, 4, 9, 11, 52, 77 };
			SortSelection(array3, N);
			foreach (var item in array3)
			{
				Console.Write(item + "\t");
			}
		}

		static int SortBubble(int[] arr, int N)
		{
			for (int i = 0; i < arr.Length; i++)
			{
				for (int j = 0; j < arr.Length - 1; j++)
				{
					if (arr[j] < arr[j + 1])
					{
						int temp = arr[j];
						arr[j] = arr[j + 1];
						arr[j + 1] = temp;
					}
				}
			}
			return 0;
		}
		// Selection Sort
		static int SortSelection(int[] arr, int N)
		{
			for (int i = 0; i < arr.Length-1; i++)
			{
				int minInd = i;
				for (int j = i+1; j < arr.Length; j++)
				{
					if (arr[j] > arr[i])
					{
						minInd = j;

						int temp = arr[minInd];
						arr[minInd] = arr[i];
						arr[i] = temp;
					}
				}
			}
			return 0;
		}
		//Insertion Sort
		static int SortInsertion(int[] arr, int N)
		{
			int j;
			for (int i = 1; i < arr.Length; i++)
			{
				int min = arr[i];
				j = i - 1;
				while (j >= 0 && arr[j] < min)
				{
					arr[j + 1] = arr[j];
					j--;
				}
				arr[j + 1] = min;
			}
			return 0;
		}
	}
}
