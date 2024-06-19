using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_v2._0
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Введите простое арифметическое выражение -> ");
			string expression=Console.ReadLine();
			expression = expression.Replace('.', ',');
			Console.WriteLine(expression);
			String[] numbers=expression.Split('/','*','-','+');
			//for (int i = 0; i < numbers.Length; i++)
			//{
			//	Console.Write(numbers[i]+"\t");
			//}
			double a = Convert.ToDouble(numbers[0]);
			double b = Convert.ToDouble(numbers[1]);
			char s = expression[expression.IndexOfAny(new char[]{'/', '*', '-', '+' })];
			Console.WriteLine(s);
			Console.WriteLine(a);
			Console.WriteLine(b);

			switch (s)
			{
				case '+':
					Console.WriteLine($"{a}+{b} = {a+b}");
					break;
						case '*':
					Console.WriteLine($"{a}*{b} = {a * b}");
					break;
				case '/':
					Console.WriteLine($"{a}/{b} = {a / b}");
					break;
				case '-':
					Console.WriteLine($"{a}-{b} = {a - b}");
					break;
				default:
					break;
			}
			Main(args);
		}
	}
}
