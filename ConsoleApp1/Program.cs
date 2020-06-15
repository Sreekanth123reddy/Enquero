using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
     
        static void Main(string[] args)
        {
            try
            {
                var num = int.Parse("abc");
            }
            catch (Exception)
            {

                Console.WriteLine("Conversion failed");
            }
            int number;
            if(int.TryParse("abc" , out number))
            {
                Console.WriteLine(number);
            }
            else
            {
                Console.WriteLine("conversion failed");
            }
            
        }
        static void UseParams()
        {

            var calculator = new Calculator();
            Console.WriteLine(calculator.Add(1, 2));
            Console.WriteLine(calculator.Add(1, 2, 3, 4, 4));
            Console.WriteLine(calculator.Add(new int[] { 1, 2, 3, 4, 5 }));

        }
        static void UsePoints()
        {

            try
            {

                var point = new Point(10, 20);
                point.Move(new Point(40, 60));
                Console.WriteLine("points is at: {0} {1}", point.X, point.Y);
                point.Move(20, 56);
                Console.WriteLine("points is at: {0} {1}", point.X, point.Y);
            }
            catch (Exception)
            {

                Console.WriteLine("An unexpected exception");
            }
        }
    
    }

}
