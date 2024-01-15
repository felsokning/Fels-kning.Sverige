namespace Felsökning.Sverige.SMHI
{
    /// <summary>
    ///     Represents an area of interest divided by minLatitude, maxLatitude, minLongitude and maxLongitude.
    /// </summary>
    public class GeoBox
    {
        /// <summary>
        ///     Gets or sets the minimum latitude.
        /// </summary>
        [JsonPropertyName("minLatitude")]
        public double MinLatitude { get; set; }

        /// <summary>
        ///     Gets or sets the minimum longitude.
        /// </summary>
        [JsonPropertyName("minLongitude")]
        public double MinLongitude { get; set; }

        /// <summary>
        ///     Gets or sets the maximum latitude.
        /// </summary>
        [JsonPropertyName("maxLatitude")]
        public double MaxLatitude { get; set; }

        /// <summary>
        ///     Gets or sets the maximum longitude.
        /// </summary>
        [JsonPropertyName("maxLongitude")]
        public double MaxLongitude { get; set; }
    }
}