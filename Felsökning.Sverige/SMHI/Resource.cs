namespace Felsökning.Sverige.SMHI
{
    public class Resource
    {
        [JsonPropertyName("key")]
        public string Key { get; set; } = string.Empty;

        [JsonPropertyName("updated")]
        public object Updated { get; set; } = new object();

        [JsonPropertyName("title")]
        public string Title { get; set; } = string.Empty;

        [JsonPropertyName("summary")]
        public string Summary { get; set; } = string.Empty;

        [JsonPropertyName("link")]
        public List<Link> Link { get; set; } = new List<Link>(0);

        [JsonPropertyName("unit")]
        public string Unit { get; set; } = string.Empty;

        [JsonPropertyName("geoBox")]
        public GeoBox GeoBox { get; set; } = new GeoBox();
    }
}