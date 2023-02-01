using System;
namespace FactoryPattern
{
    public static class VehicleFactory
    {
        public static IVehicle GetVehicle(int wheelCount)
        {
            switch (wheelCount)
            {
                case 6:
                    return new Truck();
                case 4:
                    return new Car();
                default:
                    return new Car();

            }
        }

        
        
    }
}

