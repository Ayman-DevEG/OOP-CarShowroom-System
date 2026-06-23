namespace CarShowroomSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, User!");

            // Create instances of the Car class
            Car carToyota = new Car("ABC123", "Toyota", "Camry", 25000);
            Car carHonda = new Car("XYZ789", "Honda", "Civic", 200000);

            Customer customer1 = new Customer("Ayman", "123-456-7890", 50000);
            customer1.BuyCar(carToyota);
            Console.WriteLine("++++++++++++++++++++++++++++++");
            customer1.PrintInfo();
            customer1.PrintInfo("غلط");

            Customer customer2 = new Customer(customer1);
            customer2.Name = "Ahmed";
            customer2.Budget = 1000000;
            customer2.BuyCar(carHonda);
            customer2.BuyCar(carHonda);
            Console.WriteLine("====================================");
            customer2.PrintInfo();
            customer2.PrintInfo("secret");

        } 
    }
}
