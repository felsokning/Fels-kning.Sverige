namespace Felsökning.Sverige.ArlandaExpress
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="Departure"/> class.
    /// </summary>
    public class Departure
    {
        /// <summary>
        ///     Gets or sets the time left until departure.
        /// </summary>
        [JsonPropertyName("timeLeft")]
        public int TimeLeft { get; set; }

        /// <summary>
        ///     Gets or sets the date of the departure.
        /// </summary>
        [JsonPropertyName("departureDate")]
        public string DepartureDate { get; set; } = string.Empty;

        /// <summary>
        ///     Gets or sets the time of the departure.
        /// </summary>
        [JsonPropertyName("departureTime")]
        public string DepartureTime { get; set; } = string.Empty;

        /// <summary>
        ///     Gets or sets the day of the week of the departure.
        /// </summary>
        [JsonPropertyName("departureDayOfWeek")]
        public string DepartureDayOfWeek { get; set; } = string.Empty;

        /// <summary>
        ///     Gets or sets the date of the arrival.
        /// </summary>
        [JsonPropertyName("arrivalDate")]
        public string ArrivalDate { get; set; } = string.Empty;

        /// <summary>
        ///     Gets or sets the time of the arrival.
        /// </summary>
        [JsonPropertyName("arrivalTime")]
        public string ArrivalTime { get; set; } = string.Empty;

        /// <summary>
        ///     Gets or sets the day of the week of the arrival.
        /// </summary>
        [JsonPropertyName("arrivalDayOfWeek")]
        public string ArrivalDayOfWeek { get; set; } = string.Empty;
    }
}