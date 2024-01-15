namespace Felsökning.Sverige.SMHI
{
    public class StationSet
    {
        [JsonPropertyName("key")]
        public string Key { get; set; } = string.Empty;

        [JsonPropertyName("updated")]
        public long Updated { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; } = string.Empty;

        [JsonPropertyName("summary")]
        public string Summary { get; set; } = string.Empty;

        [JsonPropertyName("link")]
        public List<Link> Link { get; set; } = new List<Link>(0);
    }
}