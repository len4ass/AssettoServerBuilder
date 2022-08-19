using System.IO.Compression;

namespace AssettoServerBuilder.Workers
{
    public static class Archive
    {
        public static void Extract(string source, string target)
        {
            try
            {
                ZipFile.ExtractToDirectory(source, target);
            }
            catch (Exception exception)
            {
                MessageBox.Show($@"Couldn't extract {Path.GetFileName(source)}. See output.log for more info.",
                @"Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                throw;
            }
        }
    }
}

