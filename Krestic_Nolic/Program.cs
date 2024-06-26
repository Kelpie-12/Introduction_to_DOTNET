﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Krestic_Nolic
{
	internal class Program
	{

		static void Main(string[] args)
		{
			bool run = true;
			while (run) 
			{
				game(); 
				Console.SetCursorPosition(50, 25);
				Console.Write("Сыграть еще раз? (y/n)-> ");
				char v = Convert.ToChar(Console.ReadLine());
				if (v == 'y')
				{
					Console.Clear();
					run = true;
					//game();
				}
				else
				{
					run = false;	
				}
			}
		}



		//Console.WriteLine(list[number_cell]);



		static void print_krestic(int x, int y)
		{

			for (int i = 0; i < 5; i++)
			{
				for (int j = 0; j < 5; j++)
				{
					if (i == j || 5 - i - 1 == j)
					{
						Console.SetCursorPosition(i + x, j + y);
						Console.Write("*");
					}
					else
					{
						//Console.Write(" ");
					}

				}
			}
		}
		static void print_nolic(int x, int y)
		{
			for (int i = 0; i < 5; i++)
			{
				for (int j = 0; j < 5; j++)
				{
					if (i == 4 || 4 == j || i == 0 || j == 0)
					{
						Console.SetCursorPosition(i + x, j + y);
						Console.Write("*");
					}
					else
					{
						//Console.Write(" ");
					}

				}
			}
		}
		static void print_pole()
		{
			for (int i = 0; i < 25; i++)
			{
				for (int j = 0; j < 32; j += 8)
				{
					Console.SetCursorPosition(i, j);
					Console.Write("*");
				}
			}
			for (int i = 0; i < 32; i += 8)
			{
				for (int j = 0; j < 25; j++)
				{
					Console.SetCursorPosition(i, j);
					Console.Write("*");
				}
			}
		}
		static void print_obvodka(int x, int y, int x_new, int y_new)
		{
			for (int i = 0; i < 7; i++)
			{
				for (int j = 0; j < 7; j++)
				{
					if (i == 6 || 6 == j || i == 0 || j == 0)
					{
						Console.SetCursorPosition(i + x, j + y);
						//Console.BackgroundColor = ConsoleColor.Red;
						Console.Write(" ");
						//Console.ResetColor();
					}
					else
					{
						//Console.Write(" ");
					}

				}
			}
			for (int i = 0; i < 7; i++)
			{
				for (int j = 0; j < 7; j++)
				{
					if (i == 6 || 6 == j || i == 0 || j == 0)
					{
						Console.SetCursorPosition(i + x_new, j + y_new);
						Console.BackgroundColor = ConsoleColor.White;
						Console.Write(" ");
						Console.ResetColor();
					}
					else
					{
						//Console.Write(" ");
					}

				}
			}
		}
		static bool win_game(List<int> list)
		{
			if ((list[0] == list[1] && list[0] == list[2]) || (list[0] == list[3] && list[0] == list[6]))
			{
				return true;
			}
			else if ((list[3] == list[4] && list[3] == list[5]) || (list[1] == list[4] && list[1] == list[7]))
			{
				return true;
			}
			else if ((list[6] == list[7] && list[6] == list[8]) || (list[2] == list[5] && list[2] == list[6]))
			{
				return true;
			}
			else if ((list[0] == list[4] && list[0] == list[8]) || (list[2] == list[4] && list[2] == list[6]))
			{
				return true;
			}
			return false;
		}

		static void game()
		{
			bool step_game = true, s = true;
			int number_cell = 0;
			List<int> list = new List<int>() { 3, 4, 5, 6, 7, 8, 9, 10, 11 };
			Dictionary<int, int> x = new Dictionary<int, int>() { { 0, 2 }, { 1, 10 }, { 2, 18 }, { 3, 2 }, { 4, 10 }, { 5, 18 }, { 6, 2 }, { 7, 10 }, { 8, 18 } };
			Dictionary<int, int> y = new Dictionary<int, int>() { { 0, 2 }, { 1, 2 }, { 2, 2 }, { 3, 10 }, { 4, 10 }, { 5, 10 }, { 6, 18 }, { 7, 18 }, { 8, 18 } };
			print_pole();
			print_obvodka(x[number_cell + 1] - 1, y[number_cell + 1] - 1, x[number_cell] - 1, y[number_cell] - 1);
			for (int step = 0; step < 9;)
			{
				//ConsoleKeyInfo key = Console.ReadKey(true);
				if (step_game)
				{
					Console.SetCursorPosition(50, 10);
					Console.Write("Ход крестик");
				}
				else
				{
					Console.SetCursorPosition(50, 10);
					Console.Write("Ход нолик");
				}
				s = true;
				while (s)
				{
					ConsoleKeyInfo key = Console.ReadKey(true);
					if (key.Key == ConsoleKey.LeftArrow)
					{
						if (number_cell <= 0)
						{
							number_cell = 0;
						}
						else
						{
							number_cell--;
						}
						print_obvodka(x[number_cell + 1] - 1, y[number_cell + 1] - 1, x[number_cell] - 1, y[number_cell] - 1);
					}
					else if (key.Key == ConsoleKey.RightArrow)
					{

						if (number_cell >= 8)
						{
							number_cell = 8;
						}
						else
						{
							number_cell++;
						}
						print_obvodka(x[number_cell - 1] - 1, y[number_cell - 1] - 1, x[number_cell] - 1, y[number_cell] - 1);
					}
					else if (key.Key == ConsoleKey.DownArrow)
					{
						int new_number_cell = number_cell;
						new_number_cell += 3;
						if (new_number_cell > 8)
						{
							number_cell = new_number_cell - 3;
						}
						else
						{
							number_cell += 3;
						}
						print_obvodka(x[number_cell - 3] - 1, y[number_cell - 3] - 1, x[number_cell] - 1, y[number_cell] - 1);
					}
					else if (key.Key == ConsoleKey.UpArrow)
					{
						int new_number_cell = number_cell;
						new_number_cell -= 3;
						if (new_number_cell < 0)
						{
							number_cell = new_number_cell + 3;
						}
						else
						{
							number_cell -= 3;
						}
						print_obvodka(x[number_cell + 3] - 1, y[number_cell + 3] - 1, x[number_cell] - 1, y[number_cell] - 1);

					}
					else if (key.Key == ConsoleKey.Escape)
					{
						s = false;
						step = 10;
						Console.SetCursorPosition(50, 12);
						Console.WriteLine("Игра завершена");
						Console.SetCursorPosition(50, 25);
					}
					if (key.Key == ConsoleKey.Enter)
					{
						if (step_game)
						{
							if (list[number_cell] != 1)
							{
								print_krestic(x[number_cell], y[number_cell]);
								list[number_cell] = 1;
								if (win_game(list))
								{
									step = 10;
									Console.SetCursorPosition(50, 12);
									Console.WriteLine("Победа крестик");
									Console.SetCursorPosition(50, 25);
								}
								step_game = false;
								step++;

							}
						}
						else
						{
							if (list[number_cell] != 1)
							{
								print_nolic(x[number_cell], y[number_cell]);
								list[number_cell] = -1;
								if (win_game(list))
								{
									step = 10;
									Console.SetCursorPosition(50, 12);
									Console.WriteLine("Победа нолик");
									Console.SetCursorPosition(50, 25);
								}
								step_game = true;
								step++;
							}
						}
						s = false;
					}
				}
			}
		

		}
	}
}
