using System.IO;

namespace CSharpInterfaceExten
{
    public class FileLogger : ILogger
    {
        private readonly string path;

        public FileLogger(string path)
        {
            this.path = path;
        }
        public void LogError(string message)
        {
            Log(message, "Error");

        }

        public void LogInfo(string message)
        {

            Log(message, "INFo");
        }

        private void Log(string message ,string messageType)
        {
            using (var streamwriter=new StreamWriter(path,true)) {
                streamwriter.WriteLine(messageType + " :" + message);
            }
        }
    }
}
