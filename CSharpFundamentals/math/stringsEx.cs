using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals.math
{
    public class stringsEx
    {
    public void stringEx()
        {
            var firstName = "Smith";
            var lastName = "Mary";
            var fn = firstName + " " + lastName;
            var mfn = string.Format("My name is {0} {1}", firstName, lastName);
            Console.WriteLine(mfn);
            var path = @"hi sree
c:/folder1/folder2";
            Console.WriteLine(path);

        }
    }

}
