namespace Felsökning.Sverige.SMHI
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="Resource"/> class.
    /// </summary>
    public class Resource
    {
        /// <summary>
        ///     Gets or sets the key of the resource.
        /// </summary>
        [JsonPropertyName("key")]
        public string Key { get; set; } = string.Empty;

        /// <summary>
        ///     Gets or sets when the resource was last updated.
        /// </summary>
        [JsonPropertyName("updated")]
        public object Updated { get; set; } = new object();

        /// <summary>
        ///     Gets or sets the title of the resource.
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; } = string.Empty;

        /// <summary>
        ///     Gets or sets the summary of the resource.
        /// </summary>
        [JsonPropertyName("summary")]
        public string Summary { get; set; } = string.Empty;

        /// <summary>
        ///     Gets or sets the links of the resource.
        /// </summary>
        [JsonPropertyName("link")]
        public List<Link> Link { get; set; } = new List<Link>(0);

        /// <summary>
        ///     Gets or sets the unit of the resource.
        /// </summary>
        [JsonPropertyName("unit")]
        public string Unit { get; set; } = string.Empty;

        /// <summary>
        ///     Gets or sets the geobox of the resource.
        /// </summary>
        [JsonPropertyName("geoBox")]
        public GeoBox GeoBox { get; set; } = new GeoBox();
    }
}