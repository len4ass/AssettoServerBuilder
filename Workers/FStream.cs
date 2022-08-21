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
                MessageBox.Show($@"Failed to read {Path.GetFileName(path)}. See output.log for more information.", 
                    @"Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                Logger.Log($"{exception.Message}\n{exception}");
                return string.Empty;
            }
        }

        public static void Write(string path, string content, bool append = false)
        {
            try
            {
                if (append && !File.Exists(path))
                {
                    File.Create(path);
                }

                using var write = new StreamWriter(path, append);
                write.Write(content);
                write.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show($@"Failed to write to {path}. See output.log for more information.", 
                    @"Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                Logger.Log($"{exception.Message}\n{exception}");
            }
        }
    }
}

