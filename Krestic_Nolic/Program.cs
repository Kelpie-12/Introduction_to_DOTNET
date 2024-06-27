using System;
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

			bool step_game = true,s=true;
			int number_cell = 0;
			List<int> list = new List<int>() { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
			Dictionary<int, int> x = new Dictionary<int, int>() { { 0, 2 }, { 1, 10 }, { 2, 18 }, { 3, 2 }, { 4, 10 }, { 5, 18 }, { 6, 2 }, { 7, 10 }, { 8, 18 } };
			Dictionary<int, int> y = new Dictionary<int, int>() { { 0, 2 }, { 1, 2 }, { 2, 2 }, { 3, 10 }, { 4, 10 }, { 5, 10 }, { 6, 18 }, { 7, 18 }, { 8, 18 } };
			print_pile();
			for (int step = 0; step < 9;)
			{
				//ConsoleKeyInfo key = Console.ReadKey(true);
				if (step_game)
				{
					Console.SetCursorPosition(50, 10);
					Console.WriteLine("Ход крестик");
				}
				else
				{
					Console.SetCursorPosition(50, 10);
					Console.WriteLine("Ход нолик");
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

						if (number_cell >= 8)
						{
							number_cell = 8;
						}
						else
						{
							number_cell += 3;
						}
						print_obvodka(x[number_cell - 3] - 1, y[number_cell - 3] - 1, x[number_cell] - 1, y[number_cell] - 1);
					}
					else if (key.Key == ConsoleKey.UpArrow)
					{

						if (number_cell <= 0)
						{
							number_cell = 8;
						}
						else
						{
							number_cell -= 3;
						}
						print_obvodka(x[number_cell + 3] - 1, y[number_cell + 3] - 1, x[number_cell] - 1, y[number_cell] - 1);

					}
					if (key.Key == ConsoleKey.Enter)
					{
						if (step_game)
						{
							if (list[number_cell] != 1)
							{
								print_krestic(x[number_cell], y[number_cell]);
								list[number_cell] = 1;
								step_game = false;
								step++;
								
							}
						}
						else
						{
							if (list[number_cell] != 1)
							{
								print_nolic(x[number_cell], y[number_cell]);
								list[number_cell] = 1;
								step_game = true;
								step++;
							}
						}
						s = false;
					}					
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
						Console.Write(" ");
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
						Console.Write(" ");
					}

				}
			}
		}
		static void print_pile()
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
						Console.Write(" ");
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
						Console.Write(" ");
					}

				}
			}
		}

	}
}
