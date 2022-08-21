using IniParser.Model;

namespace AssettoServerBuilder.Types
{
    public class Entry
    {
        public string? Model { get; set; }
        public string? Skin { get; set; }
        public string? SpectatorMode { get; set; }
        public string? DriverName { get; set; }
        public string? Team { get; set; }
        public string? Guid { get; set; }
        public string? Ballast { get; set; }
        public string? Restrictor { get; set; }
        public string? Ai { get; set; }

        public SectionData ConvertToSection(string sectionName)
        {
            var section = new SectionData(sectionName);
            section.Keys.AddKey("MODEL", Model);
            section.Keys.AddKey("SKIN", Skin);
            section.Keys.AddKey("SPECTATOR_MODE", SpectatorMode);
            section.Keys.AddKey("DRIVERNAME", DriverName);
            section.Keys.AddKey("TEAM", Team);
            section.Keys.AddKey("GUID", Guid);
            section.Keys.AddKey("BALLAST", Ballast);
            section.Keys.AddKey("RESTRICTOR", Restrictor);
            section.Keys.AddKey("AI", Ai);
            return section;
        }

        public static Entry Parse(SectionData section)
        {
            string ai = section.Keys.ContainsKey("AI") ? section.Keys.GetKeyData("AI").Value : "none";
            
            return new Entry
            {
                Model = section.Keys.GetKeyData("MODEL").Value,
                Skin = section.Keys.GetKeyData("SKIN").Value,
                SpectatorMode = section.Keys.GetKeyData("SPECTATOR_MODE").Value,
                DriverName = section.Keys.GetKeyData("DRIVERNAME").Value,
                Team = section.Keys.GetKeyData("TEAM").Value,
                Guid = section.Keys.GetKeyData("GUID").Value,
                Ballast = section.Keys.GetKeyData("BALLAST").Value,
                Restrictor = section.Keys.GetKeyData("RESTRICTOR").Value,
                Ai = ai
            };
        }

        public static List<Entry> IniToEntryList(IniData ini)
        {
            return ini.Sections.Select(Parse).ToList();
        }
        
        public static IniData EntryListToIni(List<Entry> entries)
        {
            var ini = new IniData();
            for (int i = 0; i < entries.Count; i++)
            {
                ini.Sections.Add(entries[i].ConvertToSection($"CAR_{i}"));
            }

            return ini;
        }
        
        public static List<Entry> SortEntriesByAiNone(List<Entry> entries)
        {
            return entries.OrderByDescending(entry => entry.Ai == "none").ToList();
        }

        public static List<Entry> SortEntriesByAiFixed(List<Entry> entries)
        {
            return entries.OrderByDescending(entry => entry.Ai == "fixed").ToList();
        }

        public override string ToString()
        {
            return Model ?? "unknown";
        }
    }
}

