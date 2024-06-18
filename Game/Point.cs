using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
	public readonly struct Point
	{
		public Point(int x,int y)
		{
			this.x = x;
			this.y = y;
		}
		public int x { get; }
		public int y { get; }

		public void Draw()
		{
			Console.SetCursorPosition(this.x, this.y);
			Console.Write("*");
		}

		public void Clear() 
		{
			Console.SetCursorPosition(this.x, this.y);
			Console.Write(" ");
		}
	}
}
