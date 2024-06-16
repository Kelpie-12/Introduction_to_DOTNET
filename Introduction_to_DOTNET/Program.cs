//#define Class_console
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction_to_DOTNET
{
	internal class Program
	{
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
#endif
			Console.Write("Введите ваше имя: ");
			string first_name = Console.ReadLine();
			Console.Write("Введите вашу фамилию ");
			string second_name = Console.ReadLine();
			Console.Write("Введите ваш возраст ");
			int age = Convert.ToInt32(Console.ReadLine());

			/*Console.WriteLine(first_name);
            Console.WriteLine(second_name);
            Console.WriteLine(age);
            Console.WriteLine(first_name + " " + second_name + " " + age);
			Console.WriteLine(string.Format("{0} {1} {2}", first_name, second_name, age));
			Console.WriteLine($"{first_name} {second_name} {age}");*/
		}
	}
}
