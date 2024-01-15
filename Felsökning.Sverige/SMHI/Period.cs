namespace Felsökning.Sverige.SMHI
{
    public class Period
    {
        [JsonPropertyName("key")]
        public string Key { get; set; } = string.Empty;

        [JsonPropertyName("from")]
        public long From { get; set; }

        [JsonPropertyName("to")]
        public long To { get; set; }

        [JsonPropertyName("summary")]
        public string Summary { get; set; } = string.Empty;

        [JsonPropertyName("sampling")]
        public string Sampling { get; set; } = string.Empty;
    }
}