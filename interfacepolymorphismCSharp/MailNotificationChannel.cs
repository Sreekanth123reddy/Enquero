namespace interfacepolymorphismCSharp
{
    public class MailNotificationChannel : INotificationChannel
    {
        public void Send(Message mesage)
        {
            System.Console.WriteLine("SendingMail");
        }
    }
}
