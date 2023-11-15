using System.Reflection.Metadata;

namespace  interfaces;

class Car : IVehiculo
{
	private int Benzo;

	public Car(int fuel)
	{
		Benzo = fuel;
	}

	public bool Refuel(int rebenzo)
	{
		Benzo += rebenzo;
		return true;
	}

	public void Drive()
	{
		if (Benzo > 0)
		{
			Console.WriteLine("Car is moving");
		}
		else
		{
			Console.WriteLine("Not moving");
		}
	}
}
