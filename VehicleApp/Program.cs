namespace VehicleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //Vehicle vehicle = new Vehicle();
           // vehicle.Name = "X5";
           // vehicle.Model = "BMW";
           // vehicle.drive();
           // vehicle.bust();


            Vehicle v1 = new Car();
            v1.Name = "X6";
            v1.Model = "BMW";
            v1.TurnOn();
            string carText = "Bu masin uygun deyisdirildi";
            v1.drive(carText);
            v1.bust();

            Vehicle v2 = new Bike();
            v2.Name = "H2R";
            v2.Model = "Kavasaki";
            //bike.WheelCount = 2;
            v2.TurnOn();
            string bikeText = "Bu bike uygun deyisdirildi";
            v2.drive(bikeText);
            v2.drive();
            v2.bust();
        }
    }
}
