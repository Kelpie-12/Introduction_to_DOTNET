using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
	internal class Program
	{
		private const int screen_width = 60;
		private const int screen_height = 40;
		static void Main(string[] args)
		{
			Console.SetWindowSize(screen_width, screen_height);
			Console.SetBufferSize(screen_width, screen_height);
			Console.CursorVisible = false;			

			var square = new square(10, 5);
			bool play= square.move();
			while (play)
			{
				Console.Clear();
				//Draw_border();
				square.Draw();
				play=square.move();
			}
		}

		static void Draw_border()
		{
			for (int i = 0; i < screen_width; i++)
			{
				new Point(i, 0).Draw();
				new Point(i, screen_height - 1).Draw();
			}
			for (int i = 0; i < screen_height; i++)
			{
				new Point(0, i).Draw();
				new Point(screen_width - 1, i).Draw();
			}
		}
	}
}
