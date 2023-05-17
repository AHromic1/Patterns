using ConsoleApp2;

Car automobil = new CarBuilder()
	.SetManufacturer("Toyota")
	.SetColour("Blue")
	.SetYear(2023)
	.SetPlace("Germany")
	.Build();

automobil.ispisi();

