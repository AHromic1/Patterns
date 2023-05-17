using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
	internal class CarBuilder
	{
		private Car automobil;

		public CarBuilder()  //konstruktor
		{
			automobil = new Car();
		}
		/*pojedinacno postavljanje atributa ce omoguciti da se automobil "gradi" u zeljenom redoslijedu i kaskadno*/
		public CarBuilder SetManufacturer(string manufacturer)
		{
			automobil.Manufacturer = manufacturer;
			return this;
		}

		public CarBuilder SetColour(string colour)
		{
			automobil.Colour = colour;
			return this;
		}

		public CarBuilder SetYear(int year)
		{
			automobil.Year = year;
			return this;
		}

		public CarBuilder SetPlace(string place)
		{
			automobil.Place = place;
			return this;
		}

		/*vraca instancu automobil sa svim postavljenim atributima
		 */
		public Car Build()
		{
			return automobil;
		}

	}
}
