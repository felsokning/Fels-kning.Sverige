namespace Felsökning.Sverige.SMHI
{
    public class StationData
    {
        [JsonPropertyName("key")]
        public string Key { get; set; } = string.Empty;

        [JsonPropertyName("updated")]
        public long Updated { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; } = string.Empty;

        [JsonPropertyName("summary")]
        public string Summary { get; set; } = string.Empty;

        [JsonPropertyName("unit")]
        public string Unit { get; set; } = string.Empty;

        [JsonPropertyName("valueType")]
        public string ValueType { get; set; } = string.Empty;

        [JsonPropertyName("link")]
        public List<Link> Link { get; set; } = new List<Link>(0);

        [JsonPropertyName("stationSet")]
        public List<StationSet> StationSet { get; set; } = new List<StationSet>(0);

        [JsonPropertyName("station")]
        public List<Station> Station { get; set; } = new List<Station>(0);
    }
}