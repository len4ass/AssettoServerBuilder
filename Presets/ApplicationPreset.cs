namespace AssettoServerBuilder.Presets
{
    public sealed class ApplicationPreset
    {
        public string ServerName { get; set; }
        public string PathServerBase { get; set; }
        public string PathServerPacked { get; set; }
        public string PathAiFolder { get; set; }
        public string PathExtraConfig { get; set; }
        public bool ModifyEntryList { get; set; }
        public int TcpPort { get; set; }
        public int UdpPort { get; set; }
        public int HttpPort { get; set; }
        public string PathOutputFolder { get; set; }

        public ApplicationPreset()
        {
            ServerName = string.Empty;
            PathServerBase = string.Empty;
            PathServerPacked = string.Empty;
            PathAiFolder = string.Empty;
            PathExtraConfig = string.Empty;
            ModifyEntryList = true;
            TcpPort = 0;
            UdpPort = 0;
            HttpPort = 0;
            PathOutputFolder = string.Empty;
        }
    }
}