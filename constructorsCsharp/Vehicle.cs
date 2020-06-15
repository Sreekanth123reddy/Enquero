using System;

namespace constructorsCsharp
{
    public class Vehicle
    {
        private readonly string registrationNumber;

        public Vehicle(string registrationNumber)
        {
            this.registrationNumber = registrationNumber;
            Console.WriteLine("vehicle being initialized {0}", registrationNumber);
        }
    }
}
