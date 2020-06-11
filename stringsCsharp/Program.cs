using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringsCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var fullName = "Sreekanth Reddy ";
            Console.WriteLine("Trim: '{0}' ",fullName.Trim());
            Console.WriteLine("Trim: '{0}' ", fullName.Trim().ToUpper());
            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index + 1);
            Console.WriteLine("firstName:"+firstName);
            Console.WriteLine("LasrName:" + lastName);

            var names = fullName.Split();

            Console.WriteLine("firstName:" + names[0]);
            Console.WriteLine("LasrName:" + names[1]);

            Console.WriteLine(fullName.Replace("Sreekanth","SreekanthA"));
            if(String.IsNullOrWhiteSpace(null))
                Console.WriteLine("Invalid");

            var str = "25";
            var age = Convert.ToByte(str);
            Console.WriteLine("age"+age);

            float price = 29.95f;
            Console.WriteLine(price.ToString("C0"));

        }
    }
}
