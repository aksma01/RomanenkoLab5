using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Romanenko_lab5
{
    public abstract class Vehicle
    {
        public int Speed { get; set; }
        public int Capacity { get; set; }

        public abstract void Move();
    }

    public class Human : Vehicle
    {
        public override void Move()
        {
            Console.WriteLine("Walking...");
        }
    }

    public class Car : Vehicle
    {
        public override void Move()
        {
            Console.WriteLine("Driving a car...");
        }
    }

    public class Bus : Vehicle
    {
        public override void Move()
        {
            Console.WriteLine("Riding a bus...");
        }
    }

    public class Train : Vehicle
    {
        public override void Move()
        {
            Console.WriteLine("Taking a train...");
        }
    }

    public class Route
    {
        public string StartPoint { get; set; }
        public string EndPoint { get; set; }

        public Route(string startPoint, string endPoint)
        {
            StartPoint = startPoint;
            EndPoint = endPoint;
        }
    }

    public class TransportNetwork
    {
        private List<Vehicle> vehicles;

        public TransportNetwork()
        {
            vehicles = new List<Vehicle>();
        }

        public void AddVehicle(Vehicle vehicle)
        {
            vehicles.Add(vehicle);
        }

        public void MoveAllVehicles()
        {
            foreach (var vehicle in vehicles)
            {
                vehicle.Move();
            }
        }

        public void CalculateOptimalRoute(Route route, Vehicle vehicle)
        {
            Console.WriteLine($"Calculating optimal route from {route.StartPoint} to {route.EndPoint} for {vehicle.GetType().Name}");
        }

        public void BoardPassengers(Vehicle vehicle)
        {
            Console.WriteLine($"Boarding passengers on {vehicle.GetType().Name}");
        }

        public void DisembarkPassengers(Vehicle vehicle)
        {
            Console.WriteLine($"Disembarking passengers from {vehicle.GetType().Name}");
        }
    }
    class Program
    {
        static void Main()
        {
            TransportNetwork transportNetwork = new TransportNetwork();

            Car car = new Car { Speed = 60, Capacity = 5 };
            Bus bus = new Bus { Speed = 40, Capacity = 20 };
            Train train = new Train { Speed = 80, Capacity = 100 };

            transportNetwork.AddVehicle(car);
            transportNetwork.AddVehicle(bus);
            transportNetwork.AddVehicle(train);

            transportNetwork.MoveAllVehicles();

            Route route = new Route("City A", "City B");

            transportNetwork.CalculateOptimalRoute(route, car);
            transportNetwork.BoardPassengers(car);
            transportNetwork.DisembarkPassengers(car);

            Console.ReadLine();
        }
    }
}
