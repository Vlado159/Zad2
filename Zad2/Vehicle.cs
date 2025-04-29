using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    class Vehicle
    {
        public enum FuelType
        {
            Petrol,
            Diesel,
            Electric,
            Metan,
            Gas
        }
        public string brand { get; private set; }
        public string model { get; private set; }

        private int year;
        public int Year
        {
            get
            {
                return year;
            }
            private set
            {
                if (year < 1700)
                {
                    throw new Exception("Vehicle is too old.Year of release must be after 1700");//kjkjjkjkjjjjkjkjkjkjkjkjkjk
                }
                year = value;
            }
        }
        public FuelType fuel { get; private set; }

        public string canDrive { get; set; }


        public Vehicle(string Brand, string Model, int Year, FuelType Fuel, string CanDrive)
        {
            brand = Brand;
            model = Model;
            year = Year;
            fuel = Fuel;
            canDrive = CanDrive;
        }
        public string DisplayInfo()
        {
            return $"{brand}, {model}, {year}, {fuel} - {canDrive}";
        }

        
    }

    class Car : Vehicle
    {
        public int doors { get; private set; }

        public Car(string Brand, string Model, int Year, FuelType Fuel, string CanDrive, int Doors) : base(Brand, Model, Year, Fuel, CanDrive)
        {
            doors = Doors;
        }

        public new string DisplayInfo()
        {
            return $"{base.DisplayInfo()}. {doors} doors";
        }
    }

    class Motor : Vehicle
    {
        private int seats;
        public int Seats
        {
            get
            {
                return seats;
            }
            private set
            {
                if(seats < 1)
                {
                    throw new Exception("The seats must be at least one");
                }
                seats = value;
            }
        }

        public Motor(string Brand, string Model, int Year, string CanDrive,int Seats) : base(Brand, Model, Year, FuelType.Petrol, CanDrive)
        {
            seats = Seats;
        }
        public new string DisplayInfo()
        {
            return $"{base.DisplayInfo()}. {seats} seats";
        }
    }
    class Truck : Vehicle
    {
        public int trailersNumber { get; set; }

        public Truck(string Brand, string Model, int Year,FuelType Fuel, string CanDrive, int TrailersNumber) : base(Brand, Model, Year, Fuel, CanDrive)
        {
            trailersNumber = TrailersNumber;
        }
        public new string DisplayInfo()
        {
            return $"{base.DisplayInfo()}. {trailersNumber} number of trailers";
        }
    }
    class Bus : Vehicle
    {
        private int passengers;

        public int Passengers
        {
            get
            {
                return passengers;
            }
            set
            {
                if(passengers < 20)
                {
                    throw new Exception("The vehicle has to be at least for 20 people to be a buss");//hhjhjhjhhjhjhhjhjhjhj

                }
                passengers = value;
            }
        }

        public Bus(string Brand, string Model, int Year, FuelType Fuel, string CanDrive, int Passengers) : base(Brand, Model, Year, Fuel, CanDrive)
        {
            passengers = Passengers;
        }
        public new string DisplayInfo()
        {
            return $"{base.DisplayInfo()}. {passengers}  max passengers";
        }
    }

    class ElCar : Car
    {
        public double KwH { get; set; }
        public ElCar(string Brand, string Model, int Year, string CanDrive, int Doors,double kwh) : base(Brand, Model, Year, FuelType.Electric, CanDrive, Doors)
        {
            KwH = kwh;
        }
        public new string DisplayInfo()
        {
            return $"{base.DisplayInfo()}. {KwH}  KwH energy";
        }
    }

}
