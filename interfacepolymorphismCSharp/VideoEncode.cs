using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace interfacepolymorphismCSharp
{
    class VideoEncode
    {
        private readonly IList<INotificationChannel> notificationChannels;
        public VideoEncode()
        {
            notificationChannels = new List<INotificationChannel>();       
        }
        public void Encode(Video video)
        {
            foreach (var channel in notificationChannels)
                channel.Send(new Message());

        }
        public void RegisterNotificationChannel(INotificationChannel channel)
        {
            notificationChannels.Add(channel);
        }
    }
}
