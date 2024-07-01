#define single_dimensional_arrays
#define multi_dimensional_arrays
#define jagged_arrays
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Random random = new Random();
#if single_dimensional_arrays
			int[] arr = new int[50];
			for (int i = 0; i < arr.Length; i++)
			{
				arr[i] = random.Next(0, 5);
				Console.Write(arr[i] + "\t");
			}
			Console.WriteLine();
			Console.WriteLine($"Сумма чисел массива -> {arr.Sum()}");
			Console.WriteLine($"Среднее-арифметическое массива -> {arr.Sum() / arr.Length}");
			Console.WriteLine($"Минимальное значения числа массива -> {arr.Min()}");
			Console.WriteLine($"Максимальное значения числа массива -> {arr.Max()}");
			SortedDictionary<int, int> povtor_znak = new SortedDictionary<int, int>();
			for (int i = 0; i < arr.Length; i++)
			{
				if (povtor_znak.ContainsKey(arr[i]))
				{
					povtor_znak[arr[i]] += 1;
				}
				else
				{
					povtor_znak.Add(arr[i], 1);
				}
			}
			foreach (var number in povtor_znak)
			{
				Console.WriteLine($"Число -> {number.Key} повторяется {number.Value}");
			}
#endif

#if multi_dimensional_arrays
			int[,] arrays = new int[10, 10];
			int result = 0;
			for (int i = 0; i < arrays.GetLength(0); i++)
			{
				for (int j = 0; j < arrays.GetLength(1); j++)
				{
					arrays[i,j] = random.Next(10, 20);					
					result += arrays[i, j];
					Console.Write(arrays[i,j] + "\t");
				}
                Console.WriteLine();
            }
			int min = arrays[0, 0],max=arrays[0,0];
			for (int i = 0; i < arrays.GetLength(0); i++)
			{
				for (int j = 0; j < arrays.GetLength(1); j++)
				{
					if (arrays[i, j] < min)
					{
						min = arrays[i, j];
					}
					if (arrays[i, j] > max)
					{
						max = arrays[i, j];
					}
				}				
			}
			Console.WriteLine();			
			Console.WriteLine($"Сумма чисел массива -> {result}");
			Console.WriteLine($"Среднее-арифметическое массива -> {result / arrays.Length}");
			Console.WriteLine($"Минимальное значения числа массива -> {min}");
			Console.WriteLine($"Максимальное значения числа массива -> {max}");
			SortedDictionary<int, int> povtor_znak_2 = new SortedDictionary<int, int>();
			for (int i = 0; i < arrays.GetLength(0); i++)
			{
				for (int j = 0; j < arrays.GetLength(1); j++)
				{
					if (povtor_znak_2.ContainsKey(arrays[i,j]))
					{
						povtor_znak_2[arrays[i, j]] += 1;
					}
					else
					{
						povtor_znak_2.Add(arrays[i, j], 1);
					}
				}				
			}
			foreach (var number in povtor_znak_2)
			{
				Console.WriteLine($"Число -> {number.Key} повторяется {number.Value}");
			}

#endif

#if jagged_arrays
			int length = 10, res = 0,tmp=0,min_2,max_2;
			int[][] array = new int[length][];
			for (int i = 0; i < length; i++)
			{
				array[i] = new int[random.Next(3, 10)];
			}

			for (int i = 0; i < length; i++)
			{
				for (int j = 0; j < array[i].Length; j++)
				{
					array[i][j] = random.Next(30, 40);
					res += array[i][j];
					Console.Write(array[i][j] + "\t");
				}
				tmp += array[i].Length;
				Console.WriteLine();
            }
			min_2 = array[0][0];
			max_2 = array[0][0];
			for (int i = 0; i < length; i++)
			{
				for (int j = 0; j < array[i].Length; j++)
				{
					if (array[i][j]>max_2)
					{
						max_2 = array[i][j];
					}
					if (array[i][j] < min_2)
					{
						min_2 = array[i][j];
					}				
				}				
			}
			Console.WriteLine();
			Console.WriteLine($"Сумма чисел массива -> {res}");
			Console.WriteLine($"Среднее-арифметическое массива -> {res / tmp}");
			Console.WriteLine($"Минимальное значения числа массива -> {min_2}");
			Console.WriteLine($"Максимальное значения числа массива -> {max_2}");
			SortedDictionary<int, int> povtor_znak_3 = new SortedDictionary<int, int>();
			for (int i = 0; i < length; i++)
			{
				for (int j = 0; j < array[i].Length; j++)
				{
					if (povtor_znak_3.ContainsKey(array[i][j]))
					{
						povtor_znak_3[array[i][j]] += 1;
					}
					else
					{
						povtor_znak_3.Add(array[i][j], 1);
					}
				}
			}
			foreach (var number in povtor_znak_3)
			{
				Console.WriteLine($"Число -> {number.Key} повторяется {number.Value}");
			}
#endif
		}
	}
}
