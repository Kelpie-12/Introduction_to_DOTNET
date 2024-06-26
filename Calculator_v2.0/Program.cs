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
				string expression_tmp = /*"((22+33)*(44-55)+88)/2"*/expression.Replace(" ", "");// ((22 + 33) * (44 - 55) + 88) / 2
				string a = "";
				bool x = true, xx = true;
				for (int i = 0; xx != false;)
				{
					if ((expression_tmp[expression_tmp.Length - 1] == '+' || expression_tmp[expression_tmp.Length - 1] == '-' || expression_tmp[expression_tmp.Length - 1] == '*' || expression_tmp[expression_tmp.Length - 1] == '/') || (expression_tmp[0] == '+' /*|| expression_tmp[0] == '-'*/ || expression_tmp[0] == '*' || expression_tmp[0] == '/'))
					{
						Console.Write("Значение введено не верно, попробуйте еще раз ");
						correct = false;
						break;
					}
					#region 
					//for (int pi = 0; xx != false;)
					//{
					//	tmp = "";
					//	x = true;
					//	while (x)
					//	{
					//		if (pi > expression_tmp.Length - 1)
					//		{
					//			xx = false;
					//			break;
					//		}
					//		if (expression_tmp[pi] == '(' || expression_tmp[pi] == ')')
					//		{
					//			operations.Add(expression_tmp[pi]);
					//			//pi++;
					//			//tmp = "";	
					//			x = false;
					//			if (expression_tmp[pi] == ')')
					//			{
					//				pi++;
					//				break;
					//			}
					//		}
					//		else if (expression_tmp[pi] != '+' && expression_tmp[pi] != '-' && expression_tmp[pi] != '*' && expression_tmp[pi] != '/')
					//		{
					//			tmp += expression_tmp[pi];
					//			pi++;
					//		}
					//		else
					//		{
					//			x = false;
					//		}
					//	}
					//	if (tmp != "")
					//	{
					//		d_numbers.Add(Convert.ToDouble(tmp));
					//		if (pi >= expression_tmp.Length || xx == false)
					//		{
					//			break;
					//		}
					//		operations.Add(expression_tmp[pi]);
					//		//index++;
					//	}
					//	pi++;
					//}
					//tmp = "";
					#endregion

					x = true;
					int index = -1, index2 = 0;
					for (int j = 0; j < expression_tmp.Length - 1; j++)
					{
						if (expression_tmp[j] == '(')
						{
							index = j;
							index2 = index + 1;
							while (x)
							{
								if (expression_tmp[index2] == ')')
								{
									x = false;
									j = expression_tmp.Length - 1;
									break;
								}
								else if (expression_tmp[index2] == '(')
								{
									index = index2;
									index2++;
								}
								else
								{
									index2++;
								}
							}
						}
					}

					x = false;
					if (index != -1)
					{
						x = true;
						i = 0;
						//Console.WriteLine(parsing(index, index2, expression_tmp));
						for (int u = index; u != index2 + 1; u++)
						{
							a += expression_tmp[u];
						}
						expression_tmp = expression_tmp.Replace(a, Convert.ToString(parsing(index, index2, expression_tmp)));
						a = "";
					}
					else
					{
						//if (x == false)
						//{
						//	Console.WriteLine(parsing(0, expression_tmp.Length, expression_tmp));
						//}
						Console.WriteLine(parsing(0, expression_tmp.Length, expression_tmp));
						correct = true;
						break;
					}
				}
			} while (!correct);
			//Main(args);
		}

		static double count(List<double> numbers, List<char> operators)
		{
			double rezalt = 0;
			bool correct = true;
			for (int i = 0; i < operators.Count;)
			{
				if (operators[i] == '*' || operators[i] == '/')
				{
					if (operators[i] == '*')
					{
						numbers[i] *= numbers[i + 1];
					}
					else if (operators[i] == '/')
					{
						if (numbers[i + 1] == 0)
						{
							Console.Write("На ноль делить нельзя ");
							correct = false;
							break;
						}
						numbers[i] /= numbers[i + 1];
					}
					numbers.RemoveAt(i + 1);
					operators.RemoveAt(i);
					i = 0;
				}
				else
				{
					i++;
				}
			}
			if (correct != false)
			{
				for (int i = 0; ;)
				{
					if (operators.Count == 0)
					{
						rezalt = numbers[0];
						break;
					}
					if (operators[i] == '+')
					{
						numbers[i] += numbers[i + 1];
					}
					else if (operators[i] == '-')
					{
						numbers[i] -= numbers[i + 1];
					}
					numbers.RemoveAt(i + 1);
					operators.RemoveAt(i);
					i = 0;
				}
			}
			return rezalt;
		}

		static double parsing(int index, int index2, string tmp)
		{
			double rezalt = 1;
			string tmp_in = "";
			bool x = true;
			List<double> d_numbers = new List<double>();
			List<char> operations = new List<char>();
			if (tmp[index] == '(')
			{
				index++;
			}
			while (index != index2)
			{
				if (index > tmp.Length - 1)
				{
					break;
				}
				if ((tmp[index] != '+' && tmp[index] != '-' && tmp[index] != '*' && tmp[index] != '/'))
				{
					tmp_in = "";
					while (x)
					{
						if (index == index2)
						{
							break;
						}
						if ((tmp[index] != '+' && tmp[index] != '-' && tmp[index] != '*' && tmp[index] != '/') && tmp[index] != ')')
						{
							tmp_in += tmp[index];
							index++;
						}
						else
						{
							break;
						}
					}
					if (tmp_in != "")
					{
						d_numbers.Add(Convert.ToDouble(tmp_in));
						if (index == index2)
						{
							break;
						}
						operations.Add(tmp[index]);
					}
					index++;
				}
				else
				{
					if (tmp[index] == '-')
					{
						rezalt *= -1;
					}
					index++;
				}
			}
			return rezalt *= count(d_numbers, operations);
		}
	}
}
