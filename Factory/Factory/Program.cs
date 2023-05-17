namespace Factory
{
	internal class Program
	{
		static void Main(string[] args)
		{
			FruitFactory fruitFactory = new FruitFactory();
			Fruit jabuka = fruitFactory.CreateFruit("apple");
			Fruit jagoda = fruitFactory.CreateFruit("strawberry");
			

			jabuka.ispisi();
			Console.WriteLine(" ");
			jagoda.ispisi();
			
			Fruit nepoznato = fruitFactory.CreateFruit("orange"); // bacit ce se izuzetak
		}
	}
}