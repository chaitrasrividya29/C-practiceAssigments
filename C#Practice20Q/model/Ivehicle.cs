
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Model
{
    public interface IVehicle
    {
        void Drive();
    }
    public class Car1 : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Driving a car.");
        }
    }
    public class Bike1 : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Riding a bike.");
        }
    }
    public static class VehicleFactory
    {
        public static IVehicle GetVehicle(string vehicleType)
        {
            return vehicleType.ToLower() switch
            {
                "car" => new Car1(),
                "bike" => new Bike1(),
                _ => throw new ArgumentException("Invalid vehicle type")
            };
        }
    }
}

