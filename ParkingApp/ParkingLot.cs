using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Parking
{
    public class ParkingLot : IDisposable
    {
        private Guid _Id = Guid.NewGuid();

        public Guid Id
        {
            get
            {
                return _Id;
            }
        }
        public string ParkingName { get; private set; }
        public string ParkingAdress { get; private set; }
        public int ParkingCapacity { get; private set; }
        private List<Car> _cars = new List<Car>();

        //constructor with no parameters and deffault value
        public ParkingLot()
        {
            ParkingCapacity = 20;
        }

        //constructor with parking capacity
        public ParkingLot(int capacity)
        {
            ParkingCapacity = capacity;
        }

        //constructor with parking capacity, adress and name
        public ParkingLot(int capacity, string adress, string name)
        {
            ParkingCapacity = capacity;
            ParkingAdress = adress;
            ParkingName = name;
        }

        //if the lot has capacity - you can park a car
        // method if car can't be indentified
        public void AddCar()
        {
            Car undefinedCar = new Car();
            if (_cars.Count < ParkingCapacity)
            { _cars.Add(undefinedCar); }
            else
            {
                Console.WriteLine("No spaces in the parking lot!");
            }
        }

        // method if car can be indentified
        public void AddCar(Car car)
        {
            if (_cars.Count < ParkingCapacity)
            { _cars.Add(car); }
            else
            {
                Console.WriteLine("No spaces in the parking lot!");
            }
        }

        //when car leaves the parking lot you can remove it from the lot
        public void RemoveCar(Car car)
        {
            if (car.CheckOutTime.HasValue)
            {
                _cars.Remove(car);
            }
            else
            {
                Console.WriteLine("Cannot remove the car until it leaves the parking lot");
            }
        }

        //display all cars on the parking lot
        public void DisplayCars()
        {
            foreach (Car car in _cars)
            {
                Console.WriteLine($"Brand: {car.Brand}, Model: {car.Model}, Color: {car.Color}, Plate Number: {car.PlateNumber}, Check-in time: {car.CheckInTime}, Check-out time: {(car.CheckOutTime.HasValue ? car.CheckOutTime : "not checked-out")}");
            }
        }

        //get number of used and free parking spaces
        public string GetStateMessage()
        {
            return $"The parking lot has {ParkingCapacity - _cars.Count} empty lots.{_cars.Count} lots are in use";
        }

        //check out every car and dispose _cars List
        public void Dispose()
        {
            foreach(Car car in _cars)
            {
                car.Checkout();
            }
            _cars.Clear();
        }
    }
}
