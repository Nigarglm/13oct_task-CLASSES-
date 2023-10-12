using System.Data;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle[] vehicles = new Vehicle[]
            {
                new Car("Toyota", "Rav4", "Grey", 4.5, 200,4, true),
                new Car("BMW","F30","Blue",6.5, 264 ,4, true),
                new Bicycle("DerbyCycle", "Mountain Bike", "Black", 2.5, 50, "Mountain"),
                new Bicycle("MyBike","G23","Red",3, 60, "Road"),

            };

            foreach (Vehicle vehicle in vehicles) 
            {
                Console.WriteLine(vehicles);
                Console.WriteLine(vehicle.ToString());
                vehicle.GetInfo();
                Console.WriteLine($"This vehicle's Nature Harmness is {vehicle.DefineNatureHarmness}");
                
            }
        }
    }
    public abstract class Vehicle
    {
        public Vehicle(string factoryname, string model, string color, double drivetime, double drivepath)
        {
            factoryname=Factoryname; 
            model=Model; 
            color=Color;
            drivetime=DriveTime; 
            drivepath=DrivePath;
            DateTime productiondate = ProductionDate;

        }
        public string Factoryname { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int DriveTime { get; set; }
        public int DrivePath { get; set; }
        public DateTime ProductionDate { get; }


        public virtual double AverageSpeed()
        {
            return DrivePath / DriveTime;    
        }

        public virtual void GetInfo()
        {
            Console.WriteLine($"Factory Name: {Factoryname}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Color:{Color}");
            Console.WriteLine($"Drive Time: {DriveTime}");
            Console.WriteLine($"Drive Path: {DrivePath}");
            Console.WriteLine($"Production Date: {ProductionDate}");
        }

        public override string ToString()
        {
            return $"{Factoryname}{Model}";
        }
        public abstract string DefineNatureHarmness();

    }

    public class Car:Vehicle
    {
        public Car(string factoryname, string model, string color, double drivetime, double drivepath, byte doorcount, bool iselectriccar):base(factoryname,model,color,drivetime,drivepath) 
        {
            doorcount = DoorCount;
            iselectriccar = IsElectricCar;
        }

      
        public byte DoorCount { get; set; }
        public bool IsElectricCar { get; set; }

        public override string DefineNatureHarmness()
        {
            return "high";
        }

        public override void GetInfo()
        {
            Console.WriteLine($"Door count: {DoorCount}");
            Console.WriteLine($"Is Electric Car? {IsElectricCar}");
        }

    }

    public class Bicycle:Vehicle
    {
        public Bicycle(string factoryname, string model, string color, double drivetime, double drivepath, string type) :base(factoryname, model, color, drivetime, drivepath) 
        {
            type = Type;
        
        }

        public string Type { get; set; }

        public override string DefineNatureHarmness()
        {
            return "none";
        }

        public override void GetInfo()
        {
            Console.WriteLine($"Type: {Type}");
        }

    }
}