using System;

namespace constructorsCsharp
{
    public class Car : Vehicle
    {
        public Car(string registrationNumber)
            :base(registrationNumber)
        {
            Console.WriteLine("Car being initialized {0}",registrationNumber);
        }
    }
}
