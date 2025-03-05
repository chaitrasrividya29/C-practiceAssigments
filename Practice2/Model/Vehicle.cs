using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2.Model
{
     public class Vehicle
    {
        public static string Brand { get; set; }
        public static string Speed { get; set; }

        public  virtual void Displayinfo()
        {
            Console.WriteLine("Brand: " + Brand);
            Console.WriteLine("Speed: " + Speed);
        }

    }
    public class Car : Vehicle
    {
        public Car(string brand,string speed)
        {
            Brand = brand;
            Speed = speed;
            Displayinfo();

        }
    }

    public class Bike : Vehicle
    {
        public Bike (string brand,string speed)
        {
            Brand = brand;
            Speed = speed;
            Displayinfo();
;
        }
    }
    
}
