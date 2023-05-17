using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
	internal class Apple : Fruit
	{
		public override string Type => "Apple";

		public override void ispisi()
		{
			Console.WriteLine("Ovo je jabuka.");

		}
	}
}
