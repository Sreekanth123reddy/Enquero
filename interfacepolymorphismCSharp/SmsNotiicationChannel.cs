namespace interfacepolymorphismCSharp
{
    public class SmsNotiicationChannel : INotificationChannel
    {
        public void Send(Message mesage)
        {
            System.Console.WriteLine("Sending SMS");
        }
    }
}
