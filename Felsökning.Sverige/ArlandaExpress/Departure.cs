namespace Felsökning.Sverige.ArlandaExpress
{
    public class Departure
    {
        [JsonPropertyName("timeLeft")]
        public int TimeLeft { get; set; }

        [JsonPropertyName("departureDate")]
        public string DepartureDate { get; set; }

        [JsonPropertyName("departureTime")]
        public string DepartureTime { get; set; }

        [JsonPropertyName("departureDayOfWeek")]
        public string DepartureDayOfWeek { get; set; }

        [JsonPropertyName("arrivalDate")]
        public string ArrivalDate { get; set; }

        [JsonPropertyName("arrivalTime")]
        public string ArrivalTime { get; set; }

        [JsonPropertyName("arrivalDayOfWeek")]
        public string ArrivalDayOfWeek { get; set; }
    }
}