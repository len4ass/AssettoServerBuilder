using System.Diagnostics;
using System.IO.Compression;

namespace AssettoServerBuilder
{
    public static class FileExtras
    {
        public static void CopyFromArchive(string source, string target)
        {
            try
            {
                ZipFile.ExtractToDirectory(source, target);
            }
            catch (Exception)
            {
                MessageBox.Show($@"Couldn't extract {Path.GetFileName(source)}. See output.log for more info.",
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

        public static string ReadFileContent(string path)
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

        public static void WriteFileContent(string path, string content, bool append = false)
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

