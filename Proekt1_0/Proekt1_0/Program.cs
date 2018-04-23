using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proekt1_0
{
	class Strana
	{
		public string Nazvanie { get; set; }
		public string FormaPravlenie { get; set; }
		public float Plojad { get; set; }
		public Strana (string nazvanie, string formaPravlenie, float plojad)
		{
			Nazvanie = nazvanie;
			FormaPravlenie = formaPravlenie;
			Plojad = plojad;

		}
		public Strana()
		{
			Nazvanie = "";
			FormaPravlenie = "";
			Plojad = 0;
		}
		public void input()
		{
			Console.Write("Название:");
			Console.Write("Форма правления:");
			Console.Write("Площадь:");
		}
		public override string ToString()
		{
			return String.Format("Название: {0} Форма правления: {1} Площадь: {2}", Nazvanie, FormaPravlenie, Plojad);
		}

	}
	class Program
	{
		static void Main(string[] args)
		{
			Strana strana = new Strana();
			Console.WriteLine("Первая страна " + strana);
			Strana strana1 = new Strana("Беларусь","Республика",100);
			Console.WriteLine("Первая страна " + strana1);
			Console.ReadKey();
		}
	}
}
