using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proekt1_0
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hallo World");
			Console.ReadKey();
		}
	}
	class Strana
	{
		public string Nazvanie {get; set;}
		public string FormaPravlenie { get; set; }
		public float Plojad { get; set; }
	}
}
