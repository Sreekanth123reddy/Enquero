using System;

namespace CSharpInterfaceExten
{
    public class DBMigrator

    {

        private readonly ILogger _logger;

        public DBMigrator(ILogger logger )
        {
            _logger = logger;
        }

        


        public void Migrate()

        {
            _logger.LogInfo("Migrator starts at {0} " + DateTime.Now);
            

            _logger.LogInfo("Migrator ends at {0}"+ DateTime.Now);
        }
    }
}
