using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking
{
    public class Car
    {
        private Guid _Id = Guid.NewGuid();

        public Guid Id
        {
            get
            {
                return _Id;
            }
        }
        public string Brand { get; private set; }
        public string Model { get; private set; }
        public Color Color { get; private set; }
        public string PlateNumber { get; private set; }
        public DateTime CheckInTime { get; private set; }
        public DateTime? CheckOutTime { get; private set; } = null;

        // constructor if car cannot be indentified
        public Car()
        {
            Brand = "undefined";
            Model = "undefined";
            PlateNumber = "undefined";
            CheckInTime = DateTime.Now;
        }

        //constructor if color cannot be indentified
        public Car(string brand, string model, string plateNumber)
        {
            Brand = brand;
            Model = model;
            PlateNumber = plateNumber;
            CheckInTime = DateTime.Now;
        }

        //constructor if plateNumber cannot be indentified
        public Car(string brand, string model, Color color)
        {
            Brand = brand;
            Model = model;
            Color = color;
            CheckInTime = DateTime.Now;
            PlateNumber = "undefined";
        }
        //constructor if plateNumber and color cannot be indentified
        public Car(string brand, string model)
        {
            Brand = brand;
            Model = model;
            PlateNumber = "undefined";
            CheckInTime = DateTime.Now;
        }
        //fully indentified car 
        public Car(string brand, string model, Color color, string plateNumber)
        {
            Brand = brand;
            Model = model;
            Color = color;
            PlateNumber = plateNumber;
            CheckInTime = DateTime.Now;
        }

        //check out the car
        public void Checkout()
        {
            CheckOutTime = DateTime.Now;
        }

        // change color of the car
        public void ChangeColor(Color color)
        {
            Color = color;
        }
    }
}
