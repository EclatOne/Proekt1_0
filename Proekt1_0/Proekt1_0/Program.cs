using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proekt1_0
{
	/// <summary>
	/// класс Страна где описаны наши переменные
	/// </summary>
	class Country
	{ 
		public string Name { get; set; }
		public string FormOfGovernment { get; set; }  
		public float Area { get; set; }
		/// <summary>
		/// Конструктор с параметрами
		/// </summary>
		/// <param name="Name"></param>
		/// <param name="FormOfGovernment"></param>
		/// <param name="Area"></param>
		public Country (string name, string formOfGovernment, float area) 
		{
			Name = name;
			FormOfGovernment = formOfGovernment;
			Area = area;

		}
		/// <summary>
		/// Конструктор без параметра
		/// </summary>
		public Country() 
		{
			Name = "";
			FormOfGovernment = "";
			Area = 0;
		}
		/// <summary>
		/// Метод вызова конструктора по умолчанию
		/// </summary>
		public void input()
		{
			Console.Write("Название:");
			Console.Write("Форма правления:");
			Console.Write("Площадь:");
		}
		/// <summary>
		/// Метод вызова конструктора с параметрами
		/// </summary>
		/// <returns></returns>
		public override string ToString() 
		{
			return String.Format("Название: {0} Форма правления: {1} Площадь: {2}", Name, FormOfGovernment, Area);
		}

	}
	/// <summary>
	/// главный класс проекта
	/// </summary>
	class Program
	{
		static void Main(string[] args) 
		{
			Country Country = new Country();
			Console.WriteLine("Первая страна " + Country);
			Country Country1 = new Country("Беларусь","Республика",100);
			Console.WriteLine("Первая страна " + Country1);
			Console.ReadKey();
		}
	}
}
