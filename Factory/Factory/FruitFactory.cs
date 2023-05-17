using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
	/*jednostavna factory klasa u kojoj se ogleda rad ovog patterna*/
	internal class FruitFactory
	{
		public Fruit CreateFruit(string type)
		{
			switch (type.ToLower()) //toLower je za slucaj da se posalje parametar koji se ne sastoji samo od malih slova
			{
				case "apple":  //ako je poslana apple, instanciraj i vrati jabuku
					return new Apple();
				case "strawberry":  //ako je poslana strawberry, instanciraj i vrati jagodu
					return new Strawberry();
				default:
					throw new ArgumentException("Ovo voce nije implementirano.");
			}
		}
	}
}
