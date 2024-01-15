// ----------------------------------------------------------------------
// <copyright file="MhoClassification.cs" company="Felsökning">
//      Copyright © Felsökning. All rights reserved.
// </copyright>
// <author>John Bailey</author>
// ----------------------------------------------------------------------
namespace Felsökning.Sverige.SMHI
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="MhoClassification"/> class.
    /// </summary>
    public class MhoClassification
    {
        /// <summary>
        ///     Gets or sets the Swedish Translation of the MHO Classification.
        /// </summary>
        [JsonPropertyName("sv")]
        public string Svenska { get; set; } = string.Empty;

        /// <summary>
        ///     Gets or sets the English Translation of the MHO Classification.
        /// </summary>
        [JsonPropertyName("en")]
        public string English { get; set; } = string.Empty;

        /// <summary>
        ///     Gets or sets the MHO Classification Code.
        /// </summary>
        [JsonPropertyName("code")]
        public string Code { get; set; } = string.Empty;
    }
}