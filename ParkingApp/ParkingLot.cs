using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Parking
{
    public class ParkingLot
    {
        private Guid _Id = Guid.NewGuid();

        public string Id
        {
            get
            {
                return _Id.ToString();
            }
        }
        public string ParkingName { get; private set; }
        public string ParkingAdress { get; private set; }
        public int ParkingCapacity { get; private set; }
        private List<Car> _cars = new List<Car>();

        public ParkingLot(int capacity)
        {
            ParkingCapacity = capacity;
        }

        //if the lot has capacity - you can park a car
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
    }
}
