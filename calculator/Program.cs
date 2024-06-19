using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
	internal class Program
	{

		static void Main(string[] args)
		{
			int first_number = 0;
			int second_number = 0;
			char znak;
			bool work = true;
			do
			{
				Console.WriteLine("Введите первое число -> ");
				first_number = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("Второе первое число -> ");
				second_number = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("Введите знак математической операции -> ");
				znak = Convert.ToChar(Console.ReadLine());
				switch (znak)
				{
					case '+':
						Console.WriteLine(first_number + second_number);
						break;
					case '-':
						Console.WriteLine(first_number - second_number);
						break;
					case '*':
						Console.WriteLine(first_number * second_number);
						break;
					case '/':
						if (second_number == 0)
						{
							Console.WriteLine("На ноль делить нельзя");
						}
						else
						{
							Console.WriteLine(first_number / second_number);
						}
						break;
					default:
						Console.WriteLine("Неверный симовл");
						break;
				}
				Console.WriteLine("Продолжить? n/y");
				znak = Convert.ToChar(Console.ReadLine());
				if (znak=='n')
				{
					work = false;
				}

			} while (work);
			


		}
	}
}
