// ----------------------------------------------------------------------
// <copyright file="Text.cs" company="Felsökning">
//      Copyright © Felsökning. All rights reserved.
// </copyright>
// <author>John Bailey</author>
// ----------------------------------------------------------------------
namespace Felsökning.Sverige.SMHI
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="Text"/> class.
    /// </summary>
    public class Text
    {
        /// <summary>
        ///     Gets or sets the Text in Swedish.
        /// </summary>
        [JsonPropertyName("sv")]
        public string Svenska { get; set; } = string.Empty;

        /// <summary>
        ///     Gets or sets the Text in English.
        /// </summary>
        [JsonPropertyName("en")]
        public string English { get; set; } = string.Empty;
    }
}