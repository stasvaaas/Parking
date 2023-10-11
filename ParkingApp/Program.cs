namespace Parking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Color color = new Color(300, 20, 30, 155);
            Color color2 = new Color(30,45, 6, 9);

            Car mazda = new Car("mazda", "rx", "dy2202zs");
            Console.WriteLine(mazda.Id);
            
            Car toyota = new Car("toyota", "223", color, "sd1234zs");
            Console.WriteLine(toyota.Id);
            toyota.ChangeColor(color2);
            toyota.Checkout();

            ParkingLot parkingLot = new ParkingLot(10);
            ParkingLot parkingLot2 = new ParkingLot(10);

            Console.WriteLine(parkingLot.Id);
            Console.WriteLine(parkingLot2.Id);

            parkingLot.AddCar(mazda);
            parkingLot.AddCar(toyota);
            parkingLot.AddCar();

            Console.WriteLine(parkingLot.GetStateMessage());
            parkingLot.DisplayCars();
        }
    }
}
