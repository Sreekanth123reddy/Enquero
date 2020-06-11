using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = 23;
            Console.WriteLine(number);
            Console.WriteLine("{0} {1}",byte.MinValue,byte.MaxValue);
            Console.WriteLine("{0} {1}",float.MinValue,float.MaxValue);
            const float pi = 3.14f;
            Console.WriteLine(pi);
        }
    }
}
