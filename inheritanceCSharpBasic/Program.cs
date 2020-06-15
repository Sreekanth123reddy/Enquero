using Microsoft.SqlServer.Server;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritanceCSharpBasic
{

    class Program
    {
        static void Main(string[] args)
        {
            var traingle = new Traingle();
            traingle.width = 200;
            traingle.AddHyperLink("hsgfh");
            traingle.Copy();

        }
    }
}
