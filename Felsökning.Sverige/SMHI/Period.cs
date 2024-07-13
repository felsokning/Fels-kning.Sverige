namespace Felsökning.Sverige.SMHI
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="Period"/> class.
    /// </summary>
    public class Period
    {
        /// <summary>
        ///     Gets or sets the key of the period.
        /// </summary>
        [JsonPropertyName("key")]
        public string Key { get; set; } = string.Empty;

        /// <summary>
        ///     Gets or sets the from of the period.
        /// </summary>
        [JsonPropertyName("from")]
        public long From { get; set; }

        /// <summary>
        ///     Gets or sets the to of the period.
        /// </summary>
        [JsonPropertyName("to")]
        public long To { get; set; }

        /// <summary>
        ///     Gets or sets the summary of the period.
        /// </summary>
        [JsonPropertyName("summary")]
        public string Summary { get; set; } = string.Empty;

        /// <summary>
        ///     Gets or sets the sampling of the period.
        /// </summary>
        [JsonPropertyName("sampling")]
        public string Sampling { get; set; } = string.Empty;
    }
}