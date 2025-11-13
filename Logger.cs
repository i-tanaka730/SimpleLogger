namespace SimpleLogger
{
    /// <summary>
    /// シンプルなロガーです。
    /// </summary>
    public static class Logger
    {
        // ログファイルのパスです。
        private static readonly string _logFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "log.txt");

        // ログを出力します。
        public static void Log(string message)
        {
            var logEntry = $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] {message}";
            File.AppendAllText(_logFilePath);
        }
    }
}