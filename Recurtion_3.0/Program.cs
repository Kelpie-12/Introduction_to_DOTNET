﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;


namespace Recurtion_3._0
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Console.WriteLine("Введите номер этажа ");
			//int floor = Convert.ToInt32(Console.ReadLine());
			//Elevator(floor);
			Console.WriteLine("Введите число");
			int n = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine($"{n}! = {Factorial_2(n)}");
		}
		static void Elevator(int floor)
		{
			if (floor == 0)
			{
				Console.WriteLine("Вы в подвале");
				return;
			}
			Console.WriteLine($"Вы на {floor} этаже");
			Elevator(floor - 1);
			Console.WriteLine($"Вы на {floor} этаже");
		}
		static int Factorial(int n)
		{
			if (n == 0)
			{
				return 1;
			}
			int f = Factorial(n - 1) * n;
			Console.WriteLine($"{n}! = {Factorial(n)}");
			return f;
		}

		//static BigInteger Factorial_3(int n)
		//{
		//	if (n == 0)
		//	{
		//		return 1;
		//	}
		//	BigInteger f = 1;
		//	for (int i = 1; i <= n; i++)
		//	{
		//		f *= i;
		//		Console.WriteLine($"{i}! = {f}");
		//	}
		//	return f;			
		//}
		static BigInteger Factorial_2(int n)
		{
			if (n == 0)
			{
				return 1;
			}
			BigInteger f = Factorial_2(n - 1) * n;
			//Console.WriteLine($"{n}! = {Factorial(n)}");
			return f;
		}
	}
}