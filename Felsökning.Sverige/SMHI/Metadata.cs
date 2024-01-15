// ----------------------------------------------------------------------
// <copyright file="Metadata.cs" company="Felsökning">
//      Copyright © Felsökning. All rights reserved.
// </copyright>
// <author>John Bailey</author>
// ----------------------------------------------------------------------
namespace Felsökning.Sverige.SMHI
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="Metadata"/> class.
    /// </summary>
    public class Metadata
    {
        /// <summary>
        ///     Gets or sets the metadata type of the target resource.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; } = string.Empty;

        /// <summary>
        ///     Gets or sets the link to the target resource.
        /// </summary>
        [JsonPropertyName("href")]
        public string Href { get; set; } = string.Empty;
    }
}