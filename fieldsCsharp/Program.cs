using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fieldsCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer(1);
            customer.orders.Add(new Order());
            customer.orders.Add(new Order());
            Console.WriteLine(customer.orders.Count);
        }
    }
}
