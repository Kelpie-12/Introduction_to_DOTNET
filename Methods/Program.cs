using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//int len = args.Length;
			//int[] arr = new int[] { };
			//foreach (string i in args) 
			//{ 
			//	Console.WriteLine(i+"\t"); 
			//}
			//List<int> l_numbers = new List<int>();
			//foreach (string i in args)
			//{
			//	l_numbers.Add(Convert.ToInt32(i));
			//	Console.WriteLine(i + "\t");
			//}
			//Console.WriteLine(Sum(l_numbers.ToArray()));
			int a, b;
			Input(out a, out b);
			Console.WriteLine($"a = {a}\t b= {b}");
			Exchange(ref a, ref b);
			Console.WriteLine($"a = {a}\t b= {b}");
		}
		static void Input(out int a, out int b)
		{
			Console.WriteLine("a= ");
			a = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("b= ");
			b = Convert.ToInt32(Console.ReadLine());

		}
		static void Exchange(ref int a, ref int b)
		{
			int buffer = a;
			a = b;
			b = buffer;
		}
		static int Sum(params int[] numbers)
		{
			int sum = 0;
			for (int i = 0; i < numbers.Length; i++) { sum += numbers[i]; }
			return sum;
		}
	}
}
