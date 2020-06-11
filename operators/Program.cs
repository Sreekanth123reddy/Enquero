using System;

namespace operators
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 10;
            var b = 3;
            var c = 4;
            Console.WriteLine(a+b);
            Console.WriteLine(a/b);
            Console.WriteLine(a%b);
            Console.WriteLine(c>b&&b<a);
        }
    }
}
