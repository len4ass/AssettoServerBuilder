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
            foreach (var file in target.GetFiles())
            {
                file.Delete();
            }
                
            foreach (var dir in target.GetDirectories())
            {
                dir.Delete(true);
            }
        }
        
        public static void CopyFolderContents(DirectoryInfo source, DirectoryInfo target)
        {
            foreach (var dir in source.GetDirectories())
            {
                var targetSubdirectories = target.GetDirectories();
                bool foundDirectory = targetSubdirectories.Any(targetSubdirectory => targetSubdirectory.Name == dir.Name);

                CopyFolderContents(dir,
                    foundDirectory
                        ? new DirectoryInfo(Path.Combine(target.FullName, dir.Name))
                        : target.CreateSubdirectory(dir.Name));
            }

            foreach (var file in source.GetFiles())
            {
                File.Copy(file.FullName, Path.Combine(target.FullName, file.Name), true);
            }
        }
    }
}

