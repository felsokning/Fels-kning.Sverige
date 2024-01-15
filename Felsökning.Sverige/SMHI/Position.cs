namespace Felsökning.Sverige.SMHI
{
    public class Position
    {
        [JsonPropertyName("from")]
        public long From { get; set; }

        [JsonPropertyName("to")]
        public long To { get; set; }

        [JsonPropertyName("height")]
        public double Height { get; set; }

        [JsonPropertyName("latitude")]
        public double Latitude { get; set; }

        [JsonPropertyName("longitude")]
        public double Longitude { get; set; }
    }
}