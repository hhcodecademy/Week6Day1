namespace DrivingApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Drive();
            
            Airplane airplane = new Airplane();
            airplane.Drive();
            airplane.Fly();

            Bycicle bycicle = new Bycicle();
            bycicle.Drive();

            Dron dron = new Dron();
            dron.Fly();
        }
    }
}
