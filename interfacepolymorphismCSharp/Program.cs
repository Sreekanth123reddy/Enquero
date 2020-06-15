using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfacepolymorphismCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var encoder = new VideoEncode();
            encoder.RegisterNotificationChannel(new MailNotificationChannel());
            encoder.RegisterNotificationChannel(new SmsNotiicationChannel());
            encoder.Encode(new Video());
        }
    }
}
