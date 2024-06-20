//#define calc_1
#define calc_2
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_v2._0
{
	internal class Program
	{
		static void Main(string[] args)
		{
#if calc_1
			Console.Write("Введите простое арифметическое выражение -> ");
			string expression = Console.ReadLine();
			expression = expression.Replace('.', ',');
			Console.WriteLine(expression);
			String[] numbers = expression.Split('/', '*', '-', '+');
			//for (int i = 0; i < numbers.Length; i++)
			//{
			//	Console.Write(numbers[i]+"\t");
			//}
			double a = Convert.ToDouble(numbers[0]);
			double b = Convert.ToDouble(numbers[1]);
			char s = expression[expression.IndexOfAny(new char[] { '/', '*', '-', '+' })];
			Console.WriteLine(s);
			Console.WriteLine(a);
			Console.WriteLine(b);

			switch (s)
			{
				case '+':
					Console.WriteLine($"{a}+{b} = {a + b}");
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
			
#endif
			bool correct = true;
			do
			{
				correct=true;
				Console.Write("Введите простое арифметическое выражение -> ");
				string expression = Console.ReadLine();
				string s_operations = "+-/*";
				String[] s_numbers = expression.Split(/*'/', '*', '-', '+'*/s_operations.ToCharArray());
				s_numbers=s_numbers.Where(item=> item!="").ToArray();
				double[] d_numbers = new double[s_numbers.Length];
				for (int i = 0; i < s_numbers.Length; i++)
				{
					d_numbers[i] = Convert.ToDouble(s_numbers[i]);
					Console.Write(d_numbers[i] + "\t");
				}
				Console.WriteLine();
				char[] c_operations = expression.Where(item => s_operations.Contains(item)).ToArray();
				for (int i = 0; i < c_operations.Length; i++)
				{
					Console.Write(c_operations[i] + "\t");
				}
				Console.WriteLine();
				if (d_numbers.Length!=c_operations.Length+1)
				{
					correct = false;
				}
			} while (!correct);
			//Main(args);
		}
	}
}
