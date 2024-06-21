//#define calc_1
#define calc_2
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.IO;
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
				correct = true;
				Console.Write("Введите простое арифметическое выражение -> ");
				string expression = Console.ReadLine();
				string expression_tmp = expression.Replace(" ", "");
				string tmp = "";
				List<double> d_numbers = new List<double>();
				List<char> operations = new List<char>();
				bool x = true, xx = true;
				for (int i = 0; xx != false;)
				{
					if ((expression_tmp[expression_tmp.Length - 1] == '+' || expression_tmp[expression_tmp.Length - 1] == '-' || expression_tmp[expression_tmp.Length - 1] == '*' || expression_tmp[expression_tmp.Length - 1] == '/') || (expression_tmp[0] == '+' || expression_tmp[0] == '-' || expression_tmp[0] == '*' || expression_tmp[0] == '/'))
					{
						Console.Write("Значение введено не верно, попробуйте еще раз ");
						correct = false;
						break;
					}
					tmp = "";
					x = true;
					while (x)
					{
						if (i > expression_tmp.Length - 1)
						{
							xx = false;
							break;
						}
						if (expression_tmp[i] != '+' && expression_tmp[i] != '-' && expression_tmp[i] != '*' && expression_tmp[i] != '/')
						{
							tmp += expression_tmp[i];
							i++;
						}
						else
						{
							x = false;
						}
					}
					if (tmp != "")
					{
						d_numbers.Add(Convert.ToDouble(tmp));
						if (i > expression_tmp.Length || xx == false)
						{
							break;
						}
						operations.Add(expression_tmp[i]);
						//index++;
					}
					i++;
				}
				if (correct != false)
				{
					x = true;
					for (int i = 0; i < operations.Count;)
					{
						if (operations[i] == '*' || operations[i] == '/')
						{
							if (operations[i] == '*')
							{
								d_numbers[i] *= d_numbers[i + 1];
							}
							else if (operations[i] == '/')
							{
								if (d_numbers[i + 1] == 0)
								{
									Console.Write("На ноль делить нельзя ");
									correct = false;
									break;
								}
								d_numbers[i] /= d_numbers[i + 1];
							}
							d_numbers.RemoveAt(i + 1);
							operations.RemoveAt(i);
							i = 0;
						}
						else
						{
							i++;
						}
					}
					if (correct != false)
					{
						double rezalt = 0;
						x = true;
						for (int i = 0; x == true || i < operations.Count;)
						{
							if (operations.Count == 0)
							{
								rezalt = d_numbers[0];
								x = false;
								break;
							}
							if (operations[i] == '+')
							{
								d_numbers[i] += d_numbers[i + 1];
							}
							else if (operations[i] == '-')
							{
								d_numbers[i] -= d_numbers[i + 1];
							}
							d_numbers.RemoveAt(i + 1);
							operations.RemoveAt(i);
							i = 0;
						}
						Console.WriteLine(rezalt);
					}
				}

			} while (!correct);
			//Main(args);
		}
	}
}
