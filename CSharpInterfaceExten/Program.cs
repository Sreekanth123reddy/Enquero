using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInterfaceExten
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbMigrator = new DBMigrator(new ConsoleLogger());
            dbMigrator.Migrate();
            var dbMi = new DBMigrator(new FileLogger("D:\\C#\\log.txt"));
            dbMi.Migrate();
        }
    }
}
