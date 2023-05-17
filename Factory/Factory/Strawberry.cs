using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
	internal class Strawberry : Fruit
	{
		public override string Type => "Strawberry";

		public override void ispisi()
		{
			Console.WriteLine("Ovo je jagoda.");
		}
	}
}
