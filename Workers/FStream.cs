namespace AssettoServerBuilder.Workers
{
    public static class FStream
    {
        public static string Read(string path)
        {
            try
            {
                using var read = new StreamReader(path);
                return read.ReadToEnd();
            }
            catch (Exception)
            {
                MessageBox.Show($@"Couldn't read {Path.GetFileName(path)}. See output.log for more info.",
                    @"Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                throw;
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
            }
            catch (Exception)
            {
                MessageBox.Show($@"Couldn't write to {Path.GetFileName(path)}. See output.log for more info.",
                    @"Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                throw;
            }
        }
    }
}

