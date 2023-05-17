using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
	/*jednostavna apstraktna klasa iz koje ce biti nasljedjeno razlicito voce
	 */
	internal abstract class Fruit
	{
		public abstract string Type { get; }  //nema potrebe za set 

		//metoda za ispis informacija o vocu, koje ce biti override u klasama koje nasljedjuju ovu
		public abstract void ispisi();
	}
}
