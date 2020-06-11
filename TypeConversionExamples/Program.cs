using System;

namespace TypeConversionExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1000;
            byte b = (byte) i;
            Console.WriteLine(b);
            String s = "1234";
            int number = Convert.ToInt32(s);
            Console.WriteLine(number);

        }
    }
}
