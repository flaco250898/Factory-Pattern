using System;
namespace FactoryPattern
{
    public class Truck : IVehicle
    {
        public Truck()
        {
        }
    public void Drive()
        {
            Console.WriteLine("Be Careful, the Truck is on Drive!");
        }
    }
}

