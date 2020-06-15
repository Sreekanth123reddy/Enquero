namespace compositionCSharp
{
    public class Dbmigrator
    {
        public Dbmigrator(Logger loger)
        {
            Loger = loger;
        }

        public Logger Loger { get; }
        public void Migrate()
        {
            System.Console.WriteLine("you were migrating");
        }
    }
}
