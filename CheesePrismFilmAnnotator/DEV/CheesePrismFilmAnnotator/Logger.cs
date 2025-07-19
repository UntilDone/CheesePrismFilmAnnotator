using System;
using System.IO;

namespace CheesePrismFilmAnnotator
{
    public static class Logger
    {
        private static readonly string logFilePath = "app.log";

        public static void Log(string message)
        {
            string logEntry = $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] {message}";
            try
            {
                File.AppendAllText(logFilePath, logEntry + Environment.NewLine);
            }
            catch
            {
                // 파일 기록 실패 시 무시
            }
        }
    }
}
