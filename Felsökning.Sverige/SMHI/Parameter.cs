namespace Felsökning.Sverige.SMHI
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="Parameter"/> class.
    /// </summary>
    public class Parameter
    {
        /// <summary>
        ///     Gets or sets the key of the parameter.
        /// </summary>
        [JsonPropertyName("key")]
        public string Key { get; set; } = string.Empty;

        /// <summary>
        ///     Gets or sets when the parameter was last updated.
        /// </summary>
        [JsonPropertyName("updated")]
        public long Updated { get; set; }

        /// <summary>
        ///     Gets or sets the title of the parameter.
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; } = string.Empty;

        /// <summary>
        ///     Gets or sets the summary of the parameter.
        /// </summary>
        [JsonPropertyName("summary")]
        public string Summary { get; set; } = string.Empty;

        /// <summary>
        ///     Gets or sets the links of the parameter.
        /// </summary>
        [JsonPropertyName("link")]
        public List<Link> Link { get; set; } = new List<Link>(0);

        /// <summary>
        ///     Gets or sets the resources of the parameter.
        /// </summary>
        [JsonPropertyName("resource")]
        public List<Resource> Resource { get; set; } = new List<Resource>(0);
    }
}