using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vektor2d
{
	public class Vektor
	{
		public double X;
		public double Y;
		public Vektor(double x, double y)
		{
			X = x;
			Y = y;
		}
		public static Vektor operator+(Vektor a, Vektor b)
		{
			return osszead1(a, b);
		}
		public static Vektor osszead1 (Vektor a, Vektor b)
		{
			Vektor v = new Vektor(a.X + b.X, a.Y + b.Y);

			return v;
		}
		public Vektor Osszead2 (Vektor masik)
		{
			Vektor v = new Vektor(X + masik.X, Y + masik.Y);

			return v;
		}

		public void Osszead3 (Vektor masik)
		{
			X = X + masik.X;
			Y = Y + masik.Y;
		}
		public double HajlasSzog(Vektor masik)
		{
			double szamlalo = X * masik.X + Y * masik.Y;
			double nevezo = Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2))*
										Math.Sqrt(Math.Pow(masik.X, 2) + Math.Pow(masik.Y, 2));

			return szamlalo / nevezo;
		}
	}
}
