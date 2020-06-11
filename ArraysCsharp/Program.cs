using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new [] { 3, 5, 68, 26, 9 };
            //Length
            Console.WriteLine(numbers.Length);
            //IndexOf
            Console.WriteLine(Array.IndexOf(numbers,26));
            //Clear
            Array.Clear(numbers, 0, 2);
            Console.WriteLine("Effect ofClear");
            foreach(var n in numbers)
                Console.WriteLine(n);
            //copy
            Console.WriteLine("Effect of ccopy");
            int[] another = new int[3];
            Array.Copy(numbers, another, 3);
            foreach(var n in another)
                Console.WriteLine(n);
            //sort
            Console.WriteLine("Effect of sort");
            Array.Sort(numbers);
            foreach(var n in numbers)
                Console.WriteLine(n);
            //Reverse
            Console.WriteLine("Effect of reverse");
            Array.Reverse(numbers);

            foreach (var n in numbers)
                Console.WriteLine(n);


        }
    }
}
