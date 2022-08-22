using AssettoServerBuilder.Workers;

namespace AssettoServerBuilder
{
    public static class Logger
    {
        public static void Log(string content)
        {
            try
            {
                string log = $"\n[{DateTime.Now:yyyy-MM-dd HH-mm-ss}] {content}";
                FStream.Write(
                    Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), 
                        "Assetto Server Builder\\",
                        "output.log"),
                    log,
                    true);
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Failed to write log to output.log. Something's off...\n{exception.Message}\n{exception}",
                    @"Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}

