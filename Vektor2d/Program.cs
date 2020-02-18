using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vektor2d
{
	class Program
	{
		static void Main(string[] args)
		{
			Vektor a = new Vektor(1, 2);
			Vektor b = new Vektor(3, -1);
			Vektor c = a+b;
			Console.WriteLine($"{c.X} {c.Y}");

			Vektor d = a.Osszead2(b);
			Console.WriteLine($"{d.X} {d.Y}");

			a.Osszead3(b);
			Console.WriteLine($"{a.X} {a.Y}");

			Console.ReadKey();
		}
	}
}
