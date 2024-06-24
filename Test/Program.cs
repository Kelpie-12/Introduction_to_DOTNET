using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Введите номер этажа ");
			int floor=Convert.ToInt32(Console.ReadLine());
			Elevator(floor);
		}
		static void Elevator(int floor)
		{
			Console.WriteLine($"Вы на {floor} этаже");
			Elevator(floor-1);

		}
	}
	
}
