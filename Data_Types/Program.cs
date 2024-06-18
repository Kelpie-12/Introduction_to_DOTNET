//#define types_variables
//#define intgral_types
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Types
{
	
	internal class Program
	{
		static readonly string delimiter = "\n---------------------\n";
		static void Main(string[] args)
		{
#if intgral_types

			Console.WriteLine("short");
			Console.WriteLine($"Занимает {sizeof(short)} байта");
			Console.WriteLine($"Диапазон принимаемых значений {short.MinValue} ...{short.MaxValue}");
			Console.WriteLine(delimiter);

			Console.WriteLine("ushort");
			Console.WriteLine($"Занимает {sizeof(ushort)} байта");
			Console.WriteLine($"Диапазон принимаемых значений {ushort.MinValue} ...{ushort.MaxValue}");

			Console.WriteLine("int");
			Console.WriteLine($"Занимает {sizeof(int)} байта");
			Console.WriteLine($"Диапазон принимаемых значений {int.MinValue} ...{int.MaxValue}");
			Console.WriteLine(delimiter);

			Console.WriteLine("uint");
			Console.WriteLine($"Занимает {sizeof(uint)} байта");
			Console.WriteLine($"Диапазон принимаемых значений {uint.MinValue} ...{uint.MaxValue}");
			Console.WriteLine(delimiter);

			Console.WriteLine("ulong");
			Console.WriteLine($"Занимает {sizeof(ulong)} байта");
			Console.WriteLine($"Диапазон принимаемых значений {ulong.MinValue} ...{ulong.MaxValue}");
			Console.WriteLine(delimiter); 
#endif
			//ctrl +k+s
#if types_variables
			Console.WriteLine("float");
			Console.WriteLine($"Занимает {sizeof(float)} байта");
			Console.WriteLine($"Диапазон принимаемых значений {float.MinValue} ...{float.MaxValue}");
			Console.WriteLine(delimiter);

			Console.WriteLine("double");
			Console.WriteLine($"Занимает {sizeof(double)} байта");
			Console.WriteLine($"Диапазон принимаемых значений {double.MinValue} ...{double.MaxValue}");
			Console.WriteLine(delimiter);

			Console.WriteLine("decimal");
			Console.WriteLine($"Занимает {sizeof(decimal)} байта");
			Console.WriteLine($"Диапазон принимаемых значений {decimal.MinValue} ...{decimal.MaxValue}");
			Console.WriteLine(delimiter);

			Console.WriteLine("bool");
			Console.WriteLine($"Занимает {sizeof(bool)} байта");
			//Console.WriteLine($"Диапазон принимаемых значений {bool.MinValue} ...{bool.MaxValue}");
			Console.WriteLine(delimiter); 
#endif


		}
	}
}
