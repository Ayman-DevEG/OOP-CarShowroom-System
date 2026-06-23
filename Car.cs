using System;
using System.Collections.Generic;
using System.Text;

namespace CarShowroomSystem
{
    internal class Car
    {
        // Properties
        #region Properties
        public string PlateNumber { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }

        private decimal price;
        public decimal Price
        {
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Price cannot be negative.");
                }
                price = value;
            }
            get
            {
                return price;
            }
        }
        #endregion

        // Constructors
        #region Constructors
        public Car(string plateNumber, string brand, string model, decimal price)
        {
            PlateNumber = plateNumber;
            Brand = brand;
            Model = model;
            Price = price;
        } 
        #endregion
    }
}
