namespace AssettoServerBuilder.Presets
{
    public sealed class ApplicationPreset
    {
        public string ServerName { get; set; }
        public string PathServerBase { get; set; }
        public string PathServerPacked { get; set; }
        public string PathAiFolder { get; set; }
        public string PathExtraConfig { get; set; }
        public string PathServerConfig { get; set; }
        public string PathCspExtra { get; set; }
        public string PathWelcomeMessage { get; set; }
        public bool ModifyEntryList { get; set; }
        public string PathOutputFolder { get; set; }

        public ApplicationPreset()
        {
            ServerName = string.Empty;
            PathServerBase = string.Empty;
            PathServerPacked = string.Empty;
            PathAiFolder = string.Empty;
            PathExtraConfig = string.Empty;
            PathServerConfig = string.Empty;
            PathCspExtra = string.Empty;
            PathWelcomeMessage = string.Empty;
            ModifyEntryList = true;
            PathOutputFolder = string.Empty;
        }
    }
}