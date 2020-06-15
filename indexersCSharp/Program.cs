using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indexersCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var cookie = new HttpCookie();
            cookie["name"] = "sreekanth";
            Console.WriteLine(cookie["name"]);
        }
    }
}
