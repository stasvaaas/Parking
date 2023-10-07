using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking
{
    public class ParkingLot
    {
        private static int _id;
        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        public string ParkingName { get; private set; }
        public string ParkingAdress { get; private set; }
        public int ParkingCapacity { get; private set; }
        private List<Car> cars = new List<Car>();

        //Id++ so every new parking lot has it's own ID
        public ParkingLot(int capacity)
        {
            ParkingCapacity = capacity;
            Id++;
        }

        //if the lot has capacity - you can park a car
        public void AddCar(Car car)
        {
            if (cars.Count < ParkingCapacity)
            { cars.Add(car); }
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
                cars.Remove(car);
            }
            else
            {
                Console.WriteLine("Cannot remove the car until it leaves the parking lot");
            }
        }

        //display all cars on the parking lot
        public void DisplayCars()
        {
            foreach (Car car in cars)
            {
                Console.WriteLine($"Brand: {car.Brand}, Model: {car.Model}, Color: {car.Color}, Plate Number: {car.PlateNumber}, Check-in time: {car.CheckInTime}, Check-out time: {(car.CheckOutTime.HasValue ? car.CheckOutTime : "not checked-out")}");
            }
        }

        //get number of used and free parking spaces
        public string GetStateMessage()
        {
            return $"The parking lot has {ParkingCapacity - cars.Count} empty lots.{cars.Count} lots are in use";
        }
    }
}
