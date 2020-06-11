using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumExampl
{
    public enum shippingMethod
    {
        RegularAirMail=1,
        RegisteredAirMail=2,
        Express=3
    }
    class Program
    {
        static void Main(string[] args)
        {
            reference.examples();
            /*var method = shippingMethod.Express;
            Console.WriteLine((int)method);

            var methodId = 3;
            Console.WriteLine((shippingMethod)methodId);

            Console.WriteLine(method.ToString());

            var methodName = "Express";
            var sp =(shippingMethod)Enum.Parse(typeof(shippingMethod), methodName);
            Console.WriteLine(sp);
            */
        }

    }
}
