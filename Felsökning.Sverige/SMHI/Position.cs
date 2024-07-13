namespace Felsökning.Sverige.SMHI
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="Position"/> class.
    /// </summary>
    public class Position
    {
        /// <summary>
        ///     Gets or sets the from of the position.
        /// </summary>
        [JsonPropertyName("from")]
        public long From { get; set; }

        /// <summary>
        ///     Gets or sets the to of the position.
        /// </summary>
        [JsonPropertyName("to")]
        public long To { get; set; }

        /// <summary>
        ///     Gets or sets the height of the position.
        /// </summary>
        [JsonPropertyName("height")]
        public double Height { get; set; }

        /// <summary>
        ///     Gets or sets the latitude of the position.
        /// </summary>
        [JsonPropertyName("latitude")]
        public double Latitude { get; set; }

        /// <summary>
        ///     Gets or sets the longitude of the position.
        /// </summary>
        [JsonPropertyName("longitude")]
        public double Longitude { get; set; }
    }
}