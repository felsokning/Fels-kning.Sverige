namespace Felsökning.Sverige.SMHI
{
    public class Parameter
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

        [JsonPropertyName("resource")]
        public List<Resource> Resource { get; set; } = new List<Resource>(0);
    }
}