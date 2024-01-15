namespace Felsökning.Sverige.SMHI
{
    public class RecordedValue
    {
        [JsonPropertyName("date")]
        public long Date { get; set; }

        [JsonPropertyName("value")]
        public string Value { get; set; } = string.Empty;

        [JsonPropertyName("quality")]
        public string Quality { get; set; } = string.Empty;
    }
}