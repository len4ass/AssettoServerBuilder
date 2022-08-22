using System.IO.Compression;

namespace AssettoServerBuilder.Workers
{
    public static class Archive
    {
        public static void Extract(string source, string target)
        {
            ZipFile.ExtractToDirectory(source, target, true);
        }
    }
}

