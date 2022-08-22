namespace AssettoServerBuilder.Workers
{
    public static class FStream
    {
        public static string Read(string path)
        {
            try
            {
                using var read = new StreamReader(path);
                string buffer = read.ReadToEnd();
                read.Close();

                return buffer;
            }
            catch (Exception exception)
            {
                Logger.Log($"{exception.Message}\n{exception}");
                MessageBox.Show($@"Failed to read {Path.GetFileName(path)}. See output.log for more information.", 
                    @"Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return string.Empty;
            }
        }

        public static void Write(string path, string content, bool append = false)
        {
            try
            {
                using var write = new StreamWriter(path, append);
                write.Write(content);
                write.Close();
            }
            catch (Exception exception)
            {
                if (path == Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                        "Assetto Server Builder\\", 
                        "output.log"))
                {
                    MessageBox.Show($@"Failed to log information. That shouldn't happen.", 
                        @"Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }
                
                Logger.Log($"{exception.Message}\n{exception}");
                MessageBox.Show($@"Failed to write to {path}. See output.log for more information", 
                    @"Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}

