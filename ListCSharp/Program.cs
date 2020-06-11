using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int> { 34, 56, 12, 1, 5, 9 };
            numbers.Add(2);
            numbers.AddRange(new int[3] { 4, 3, 8 });
            foreach(var n in numbers)
                Console.WriteLine(n);
            Console.WriteLine();
            Console.WriteLine("Index of 55:"+numbers.IndexOf(56));
            Console.WriteLine("Last Index 8:"+numbers.LastIndexOf(8));
            Console.WriteLine("Count:"+numbers.Count);
            for(var i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == 3)
                {
                    numbers.Remove(numbers[i]);
                }
            }
            foreach (var n in numbers)
                Console.WriteLine(n);
            numbers.Clear();
            Console.WriteLine("Count:" + numbers.Count);

        }
    }
}
