namespace compositionCSharp
{
    public class Installer
    {
        public Installer(Logger loger)
        {
            Loger = loger;
        }

        public Logger Loger { get; }
        public void Install()
        {
            System.Console.WriteLine("You wrere installing....");
        }
    }
}
