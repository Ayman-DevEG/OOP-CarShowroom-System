using System;
using System.Collections.Generic;
using System.Text;

namespace CarShowroomSystem
{
    internal class Customer
    {
        // Properties
        #region Properties
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        private decimal budget;
        public decimal Budget
        {
            get { return budget; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Budget cannot be negative.");
                }
                budget = value;
            }
        }

        public List<Car> OwnedCars { get;}
        #endregion

        // Constructors
        #region Constructors
        public Customer()
        {
            OwnedCars = new List<Car>();
        }
        public Customer(string name, string phoneNumber, decimal budget)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            Budget = budget;
            OwnedCars = new List<Car>();
        }

        public Customer(Customer customer)
        {
            Name = customer.Name;
            PhoneNumber = customer.PhoneNumber;
            Budget = customer.Budget;
            OwnedCars = new List<Car>(customer.OwnedCars);
        }
        #endregion

        // Methods
        public void BuyCar(Car car)
        {
            if (Budget >= car.Price)
            {
                Budget -= car.Price;
                OwnedCars.Add(car);
                Console.WriteLine("Car purchased successfully.");
                Console.WriteLine($"Remaining budget: {Budget}");
            }
            else
            {
                Console.WriteLine("Insufficient budget to purchase this car.");
            }
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Customer: {Name} Budget: {Budget}");
        }

        public void PrintInfo(string password)
        {
            if (password == "secret")
            {
                Console.WriteLine($"Name : {Name} Phone Number: {PhoneNumber} Budget: {Budget}");
                foreach(Car car in OwnedCars)
                {
                    Console.WriteLine($"Owned Car: {car.Model} - ${car.Price}");
                }
            }
            else
            {
                Console.WriteLine("Invalid password.");
            } 
        }
    }
}
