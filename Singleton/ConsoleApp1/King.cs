using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	/*Primjer klase koja koristi Singleton pattern
	 *Singleton pattern se koristi kako bi se osiguralo da postoji samo jedna instanca odredjene klase, u ovom slučaju, 
	 *postoji samo jedan kralj i on se uvijek vraca kao instanca ove klase
	 **/
	internal class King
	{
	
       private static King? kralj;  //nullable je

		private King() { }

		public static King getInstance()
		{
			//get  //get se moglo staviti i ovdje, umjesto u nazivu metde, da omogućava pristup propertiju
			//{
				if (kralj == null)  //ukoliko ne postoji instanca kralj
				{
					kralj = new King();  //kreirati novu
				}
				return kralj; //vratiti novog kralja
			//}
			//u suprotnom nova instanca se ne pravi
		}

	}

}


