namespace Felsökning.Sverige.SMHI
{
    public class MeasurementParameter
    {
        [JsonPropertyName("key")]
        public string Key { get; set; } = string.Empty;

        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        [JsonPropertyName("summary")]
        public string Summary { get; set; } = string.Empty;

        [JsonPropertyName("unit")]
        public string Unit { get; set; } = string.Empty;
    }
}