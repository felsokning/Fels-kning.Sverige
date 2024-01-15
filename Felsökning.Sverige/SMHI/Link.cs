namespace Felsökning.Sverige.SMHI
{
    /// <summary>
    ///      Represents a link to another resource.
    /// </summary>
    public class Link
    {
        /// <summary>
        ///     Gets or sets the url to the target resource.
        /// </summary>
        [JsonPropertyName("href")]
        public string Href { get; set; } = string.Empty;

        /// <summary>
        ///     Gets or sets the mediatype of the target resource.
        /// </summary>
        [JsonPropertyName("rel")]
        public string Rel { get; set; } = string.Empty;

        /// <summary>
        ///     Gets or sets the XSD type of the target resource.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; } = string.Empty;
    }
}