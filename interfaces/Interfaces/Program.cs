using interfaces;

IVehiculo car = new Car(0);

Console.WriteLine("Benzo?");

int refueled = Convert.ToInt32(Console.ReadLine());

car.Refuel(refueled);

car.Drive();