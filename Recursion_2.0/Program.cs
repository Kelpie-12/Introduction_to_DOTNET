using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion_2._0
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine($"Factorial 4 = {Factorial(4)}");
			Console.WriteLine($"Power 2.5^3 = {Power(2.5, 3)}");
			Console.WriteLine($"fibonachi 10 = {fibonachi(10)}");
			Console.WriteLine("Заданное количество чисел из ряда Фибоначчи (10)");
			print_fibonachi(10);
			Console.WriteLine("Фибоначчи, до указанного предела (33)");
			print_fibonachi_predel(33);
		}
		static public int Factorial(int number)
		{
			if (number == 1)
				return 1;
			return Factorial(number - 1) * number;
		}
		static public double Power(double number, int power)
		{
			if (power == 0)
				return 1;
			return number * Power(number, --power);
		}
		static public int fibonachi(int number)
		{
			if (number == 1 || number == 2)
				return 1;
			if (number == 0)
				return 0;
			return fibonachi(number - 1) + fibonachi(number - 2);
		}
		static public void print_fibonachi(int iter)
		{
			for (int i = 1; i < iter + 1; i++)
			{
				Console.WriteLine($"fibonachi {i} = {fibonachi(i)}");
			}
		}
		static public void print_fibonachi_predel(int iter)
		{
			int i = 0;
			while (iter >= fibonachi(i))
			{
				Console.WriteLine($"fibonachi {i} = {fibonachi(i)}");
				i++;
			}
		}
	}
}
