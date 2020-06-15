using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace compositionCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var migrator = new Dbmigrator(new Logger());
            migrator.Migrate();
            Logger log = new Logger();
            var ins = new Installer(log);
            ins.Install();
        }
    }
}
