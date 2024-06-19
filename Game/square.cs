using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
	public class square
	{
		public square(int initial_x, int initial_y)
		{
			Square = new Point(initial_x, initial_y);
			Square.Draw();
		}
		public Point Square { get; private set; }

		public bool move()
		{
			int screen_width = 60;
			int screen_height = 40;
			ConsoleKeyInfo key = Console.ReadKey(true);
			Clear();
			if (ConsoleKey.UpArrow == key.Key||ConsoleKey.W==key.Key)
			{
				//Square.x == 0 || Square.x == screen_width - 1 || Square.y == screen_height - 1 || Square.y == 0
				if (Square.y - 1 > 0)
				{
					Square = new Point(Square.x, Square.y - 1);
				}
				else
				{
					Square = new Point(Square.x, Square.y);
				}

			}
			else if (ConsoleKey.DownArrow == key.Key || ConsoleKey.S == key.Key)
			{
				if (Square.y + 1 < screen_height - 1)
				{
					Square = new Point(Square.x, Square.y + 1);
				}
				else
				{
					Square = new Point(Square.x, Square.y);
				}

			}
			else if (ConsoleKey.LeftArrow == key.Key || ConsoleKey.A == key.Key)
			{
				if (Square.x - 1 > 0)
				{
					Square = new Point(Square.x - 1, Square.y);
				}
				else
				{
					Square = new Point(Square.x, Square.y);
				}
			}
			else if (ConsoleKey.RightArrow == key.Key || ConsoleKey.D == key.Key)
			{
				if (Square.x + 1 < screen_width - 1)
				{
					Square = new Point(Square.x + 1, Square.y);
				}
				else
				{
					Square = new Point(Square.x, Square.y);
				}
			}
		 
			if (ConsoleKey.Escape==key.Key)
			{
				return false;
			}
			return true;
		}
		public void Draw()
		{
			Square.Draw();
		}
		public void Clear()
		{
			Square.Clear();
		}
	}
}
