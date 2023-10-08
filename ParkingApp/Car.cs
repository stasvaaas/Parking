﻿using System;
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

        public string Id
        {
            get
            {
                return _Id.ToString();
            }
        }
        public string Brand { get; private set; }
        public string Model { get; private set; }
        public Color Color { get; private set; }
        public string PlateNumber { get; private set; }
        public DateTime CheckInTime { get; private set; }
        public DateTime? CheckOutTime { get; private set; } = null;

        
        public Car(string brand, string model, Color color, string plateNumber)
        {
            Brand = brand;
            Model = model;
            Color = color;
            PlateNumber = plateNumber;
            CheckInTime = DateTime.Now;
            Color = color;
            //_ = _Id;
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
