using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
	/*klasa Car koja predstavlja automonil, informacije o njemu se sastoje od propertija: 
	 * proizvodjac, boja, godina proizvodnje, mjesto proizvodnje
	 * */
	internal class Car
	{

		public Car() { }
		public string Manufacturer { get; set; }
		public string Colour { get; set; }
		public int Year { get; set; }
		public string Place { get; set; }
		public void ispisi()
		{
			Console.WriteLine($"Proizvodjac:", Manufacturer);
			Console.WriteLine($"Boja: {Colour}");
			Console.WriteLine($"Godina proizvodnje: {Year}");
			Console.WriteLine($"Mjesto proizvodnje: {Place}");
		}
	}
}
