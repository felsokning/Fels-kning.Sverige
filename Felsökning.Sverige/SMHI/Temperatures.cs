namespace Felsökning.Sverige.SMHI
{
    public class Temperatures
    {
        [JsonPropertyName("updated")]
        public long Updated { get; set; }

        [JsonPropertyName("parameter")]
        public MeasurementParameter Parameter { get; set; } = new MeasurementParameter();

        [JsonPropertyName("station")]
        public Station Station { get; set; } = new Station();

        [JsonPropertyName("period")]
        public Period Period { get; set; } = new Period();

        [JsonPropertyName("position")]
        public List<Position> Position { get; set; } = new List<Position>(0);

        [JsonPropertyName("link")]
        public List<Link> Link { get; set; } = new List<Link>(0);

        [JsonPropertyName("value")]
        public List<RecordedValue> Value { get; set; } = new List<RecordedValue>(0);
    }
}