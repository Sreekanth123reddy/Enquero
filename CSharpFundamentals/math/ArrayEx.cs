using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals.math
{
   public  class ArrayEx
    {
       public static void Arrays()  {
            var number = new int[3];
            number[0] = 1;
            Console.WriteLine(number[0]);
            Console.WriteLine(number[1]);
            Console.WriteLine(number[2]);
            var flags = new bool[3];
            flags[0] = true;
            Console.WriteLine(flags[0]);
            Console.WriteLine(flags[1]);
            Console.WriteLine(flags[2]);

            var str = new string[3] { "sree", "kanth", "reddy" };
        }

    }
}
