namespace Parking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Color color = new Color(30, 20, 30, 155);
            Color color2 = new Color(30, 45, 6, 9);

            Car mazda = new Car("mazda", "rx", color, "dy2202zs");
            Console.WriteLine(mazda.Id);
            Car toyota = new Car("toyota", "223", color, "sd1234zs");
            toyota.ChangeColor(color2);

            toyota.Checkout();
            Console.WriteLine(toyota.CheckOutTime);
            ParkingLot parkingLot = new ParkingLot(10);
            Console.WriteLine(parkingLot.Id);
            parkingLot.AddCar(mazda);
            parkingLot.AddCar(toyota);
            Console.WriteLine(parkingLot.GetStateMessage());
            parkingLot.DisplayCars();
        }
    }
}
