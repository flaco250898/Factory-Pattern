namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            int numOfWheels;
            bool input = false;

            do
            {
                Console.WriteLine("Please enter the amount of tires your vehicle is going to have: ");
                input = int.TryParse(Console.ReadLine(), out numOfWheels);

            } while (input == false);

            var vehicle = VehicleFactory.GetVehicle(numOfWheels);
            vehicle.Drive();

        }
    }
}
