// ----------------------------------------------------------------------
// <copyright file="WarningReference.cs" company="Felsökning">
//      Copyright © Felsökning. All rights reserved.
// </copyright>
// <author>John Bailey</author>
// ----------------------------------------------------------------------
namespace Felsökning.Sverige.SMHI
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="WarningReference"/> class.
    /// </summary>
    public class WarningReference
    {
        /// <summary>
        ///     Gets or sets the XSD type of the target resource.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; } = string.Empty;

        /// <summary>
        ///     Gets or sets the url to the target resource.
        /// </summary>
        [JsonPropertyName("href")]
        public string Href { get; set; } = string.Empty;
    }
}