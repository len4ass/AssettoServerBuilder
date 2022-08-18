namespace AssettoServerBuilder
{
    public static class Logger
    {
        public static void Log(string content)
        {
            string log = $"[{DateTime.Now:yyyy-MM-dd HH-mm-ss}] {content}";
            FileExtras.WriteFileContent(Path.Combine(Path.GetFullPath(Form1.s_AppBasePath), "output.log"), log, true);
        }
    }
}

