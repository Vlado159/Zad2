using Vehicles;
namespace Zad2
    
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Car car = new Car("BMW", "M5", 2018, Vehicle.FuelType.Petrol, "Drivable", 0);
            //Console.WriteLine(car.DisplayInfo());

            Motor motor = new Motor("Honda", "Shadow", 2008, "Drivable", 0);
            Console.WriteLine(motor.DisplayInfo());

            //Truck truck = new Truck("Scania", "CB2", 1850,Vehicle.FuelType.Diesel, "Drivable", 1);
            //Console.WriteLine(truck.DisplayInfo());

            //Bus bus = new Bus("Mercedes", "Benz", 1699,Vehicle.FuelType.Gas, "Non-Drivable", 19);
            //Console.WriteLine(bus.DisplayInfo());

            //ElCar Elcar = new ElCar("Tesla", "Model S", 2018, "Drivable", 4,300);
            //Console.WriteLine(Elcar.DisplayInfo());

        }
    }
}
