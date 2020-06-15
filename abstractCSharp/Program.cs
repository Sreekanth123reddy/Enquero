using Microsoft.Win32.SafeHandles;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractCSharp

{
    class Program
    {
        static void Main(string[] args)
        {
            Traingle t = new Traingle();
            t.Draw();
            t.Copy();
            Rectangle r = new Rectangle();
            r.Draw();
            r.Copy();

           // Shape s = new Shape(); not possible



        }
    }
}
