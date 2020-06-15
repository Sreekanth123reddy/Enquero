
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpEncapsulation
{
    class Program
    {

        static void Main(string[] args)
        {
            var person = new Person();
            person.SetBirthDate(new DateTime(1998, 1, 1));
            Console.WriteLine(person.GetBirthDate());
            Console.WriteLine("-----------");
            var dob = new EncapsulationEx(new DateTime(1997, 10, 12));
            Console.WriteLine(dob.Age);
        }
    }
}
