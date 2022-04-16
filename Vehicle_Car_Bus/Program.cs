using System;
using Vehicle_Car_Bus.Models;

namespace Vehicle_Car_Bus
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("BMW", "M3", 2020);

            Car car1 = new Car("Mercedes", "E220", 2020);


            Bus bus = new Bus(55, 2012);

            Bus bus1 = new Bus(35, 2021);

            Vehicle[] vehicles = {car, car1, bus, bus1};

            foreach (Vehicle v in vehicles)
            {
                v.ShowInfo();
            }
        }
    }
}

