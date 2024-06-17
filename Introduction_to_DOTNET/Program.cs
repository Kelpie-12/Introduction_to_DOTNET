//#define Class_console
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Introduction_to_DOTNET
{
	internal class Program
	{
		public static void print_task_1()
		{
			int length = 5;
			Console.WriteLine("0)");
			for (int i = 0; i < length; i++)
			{
				for (int j = 0; j < length; j++)
				{
					Console.Write("*");
				}
				Console.WriteLine();
			}
			Console.WriteLine("1)");
			Console.WriteLine();
			for (int i = 0; i < length; i++)
			{
				for (int j = 0; j < length; j++)
				{
					if (i >= j)
					{
						Console.Write("*");
					}
				}
				Console.WriteLine();
			}
			Console.WriteLine("2)");
			Console.WriteLine();
			for (int i = 0; i < length; i++)
			{
				for (int j = 0; j < length; j++)
				{
					if (i <= j)
					{
						Console.Write("*");
					}
				}
				Console.WriteLine();
			}
			Console.WriteLine("3)");
			Console.WriteLine();
			for (int i = 0; i < length; i++)
			{
				for (int j = 0; j < length; j++)
				{
					if (i <= j)
					{
						Console.Write("*");
					}
					else
					{
						Console.Write(" ");
					}
				}
				Console.WriteLine();
			}
			Console.WriteLine("4)");
			Console.WriteLine();
			for (int i = 0; i < length; i++)
			{
				for (int j = 0; j < length; j++)
				{
					if (i + j >= length - 1)
					{
						Console.Write("*");
					}
					else
					{
						Console.Write(" ");
					}
				}
				Console.WriteLine();
			}
			Console.WriteLine("5)");
			Console.WriteLine();
			length += 2;
			for (int i = 0; i < length; i++)
			{
				for (int j = 0; j < length * 2; j++)
				{
					if (j == ((length + 1) / 2 + i + (length / 2)))
					{
						Console.Write("\\");
					}
					else if (j == length / 2 - i + 3)
					{
						Console.Write("/");
					}
					else
					{
						Console.Write(" ");
					}
				}
				Console.WriteLine();
			}
			for (int i = 0; i < length; i++)
			{
				for (int j = 0; j < length * 2; j++)
				{
					if (i == j)
					{
						Console.Write("\\");
					}
					else if (j == length - i + length - 1)
					{
						Console.Write("/");
					}
					else
					{
						Console.Write(" ");
					}
				}
				Console.WriteLine();
			}
			length -= 2;
			Console.WriteLine("6)");
			Console.WriteLine();
			for (int i = 0; i < length; i++)
			{
				for (int j = 0; j < length; j++)
				{
					if (j % 2 == 0)
					{
						Console.Write("+");
					}
					else
					{
						Console.Write("-");
					}
				}
				Console.WriteLine();
			}
		}

		public static void print_task_2()
		{
			Console.WriteLine("Задание 2 ");
			Console.Write("Введите размер доски -> ");
			int length = Convert.ToInt32(Console.ReadLine());
			for (int i = 0; i < length; i++)
			{				
				Console.CursorTop = 5 + i;
				for (int j = 0; j < length; j++)
				{
					Console.CursorLeft = 5+j;
					if ((j % 2 == 1) && i % 2 == 1)
					{						
						Console.BackgroundColor = ConsoleColor.White;
						Console.ForegroundColor = ConsoleColor.White;
					}
					else if (j % 2 == 0 && i % 2 == 0)
					{						
						Console.BackgroundColor = ConsoleColor.White;
						Console.ForegroundColor = ConsoleColor.White;
					}					
					else
					{
						Console.BackgroundColor = ConsoleColor.Black;
						Console.ForegroundColor = ConsoleColor.Black;
					}
					Console.Write(" ");
				}
				Console.WriteLine();
			}
			Console.WriteLine();
			Console.ResetColor();
		}

		public static void print_tack_3()
		{
			string grid3 = "*****";
			string grid4 = "     ";
			Console.WriteLine("Задание 3 ");
			Console.Write("Введите размер доски -> ");
			int length = Convert.ToInt32(Console.ReadLine());
			for (int i = 0; i < length; i++)
			{
				for (int j = 0; j < 5; j++)
				{
					for (int o = 0; o < length; o++)
					{
						if (o % 2 == 0 && i % 2 == 0)
						{
							Console.Write(grid3);
						}
						else if ((o % 2 == 1) && i % 2 == 1)
						{
							Console.Write(grid3);
						}
						else
						{
							Console.Write(grid4);
						}
					}
					Console.WriteLine();
				}
			}
		}
		static void Main(string[] args)
		{
#if Class_console
            Console.Title = "Введение в .NET";
            Console.WriteLine("\t\tHello .NET");
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.CursorLeft = 32;
            Console.CursorTop = 11;
            Console.Beep(370, 2000);
            Console.Clear();
            //Console.SetCursorPosition(22, 11);
            Console.WriteLine("Привет .NET");
            Console.ResetColor(); 
			/*
			Console.Write("Введите ваше имя: ");
			string first_name = Console.ReadLine();
			Console.Write("Введите вашу фамилию ");
			string second_name = Console.ReadLine();
			Console.Write("Введите ваш возраст ");
			int age = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine(first_name);
            Console.WriteLine(second_name);
            Console.WriteLine(age);
            Console.WriteLine(first_name + " " + second_name + " " + age);
			Console.WriteLine(string.Format("{0} {1} {2}", first_name, second_name, age));
			Console.WriteLine($"{first_name} {second_name} {age}");*/
#endif

			print_task_1();
			print_task_2();
			print_tack_3();
			

		}
	}


}

