using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dane
{
    public class Logger
    {
        private readonly string logFilePath;

        public Logger(string logFilePath)
        {
            this.logFilePath = logFilePath;
        }

        public void LogBallData(int ballId, double positionX, double positionY, TimeSpan timestamp)
        {
            string json = $"{{ \"ID kuli\": {ballId}, \"Pozycja X\": {positionX}, \"Pozycja Y\": {positionY}, \"Znak czasu\": \"{timestamp}\" }}";

            try
            {
                using (StreamWriter sw = File.AppendText(logFilePath))
                {
                    sw.WriteLine(json);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error while logging ball data: {ex.Message}");
            }
        }
    }
}
