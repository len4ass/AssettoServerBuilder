using System.Diagnostics;

namespace AssettoServerBuilder.Workers
{
    public static class Folder
    {
        public static void OpenFolder(string target)
        {
            var startInfo = new ProcessStartInfo
            {
                Arguments = target,
                FileName = "explorer.exe"
            };

            Process.Start(startInfo);
        }

        public static void CleanFolder(DirectoryInfo target)
        {
            try
            {
                foreach (var file in target.GetFiles())
                {
                    file.Delete();
                }
                
                foreach (var dir in target.GetDirectories())
                {
                    dir.Delete(true);
                }
            } catch (Exception)
            {
                MessageBox.Show($@"Failed to clean {target.FullName}. See output.log for more info.",
                    @"Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                throw;
            }
        }
        
        public static void CopyFolderContents(DirectoryInfo source, DirectoryInfo target)
        {
            foreach (var dir in source.GetDirectories())
            {
                try
                {
                    CopyFolderContents(dir, target.CreateSubdirectory(dir.Name));
                } catch (Exception)
                {
                    MessageBox.Show(@"Couldn't copy folder contents. See output.log for more info.",
                    @"Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                    throw;
                }
            }

            foreach (var file in source.GetFiles())
            {
                try
                {
                    file.CopyTo(Path.Combine(target.FullName, file.Name));
                }
                catch (Exception)
                {
                    MessageBox.Show($@"Couldn't copy {file.Name}. See output.log for more info.",
                    @"Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                    throw;
                }
            }
        }
    }
}

