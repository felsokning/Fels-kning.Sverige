// ----------------------------------------------------------------------
// <copyright file="WarningArea.cs" company="Felsökning">
//      Copyright © Felsökning. All rights reserved.
// </copyright>
// <author>John Bailey</author>
// ----------------------------------------------------------------------
namespace Felsökning.Sverige.SMHI
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="WarningLevel"/> class.
    /// </summary>
    public class WarningLevel
    {
        /// <summary>
        ///     Gets or sets the Warning Level in Swedish.
        /// </summary>
        [JsonPropertyName("sv")]
        public string Svenska { get; set; } = string.Empty;

        /// <summary>
        ///     Gets or sets the Warning Level in English.
        /// </summary>
        [JsonPropertyName("en")]
        public string English { get; set; } = string.Empty;

        /// <summary>
        ///     Gets or sets the Warning Level Code.
        /// </summary>
        [JsonPropertyName("code")]
        public string Code { get; set; } = string.Empty;
    }
}