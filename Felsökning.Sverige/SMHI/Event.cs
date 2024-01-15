// ----------------------------------------------------------------------
// <copyright file="Event.cs" company="Felsökning">
//      Copyright © Felsökning. All rights reserved.
// </copyright>
// <author>John Bailey</author>
// ----------------------------------------------------------------------
namespace Felsökning.Sverige.SMHI
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="Event"/> class.
    /// </summary>
    public class Event
    {
        /// <summary>
        ///     Gets or sets the Swedish Translation of the Event.
        /// </summary>
        [JsonPropertyName("sv")]
        public string Svenska { get; set; } = string.Empty;

        /// <summary>
        ///     Gets or sets the English Translation of the Event.
        /// </summary>
        [JsonPropertyName("en")]
        public string English { get; set; } = string.Empty;

        /// <summary>
        ///     Gets or sets the Code of the Event.
        /// </summary>
        [JsonPropertyName("code")]
        public string Code { get; set; } = string.Empty;

        /// <summary>
        ///     Gets or sets the <see cref="SMHI.MhoClassification"/> of the Event.
        /// </summary>
        [JsonPropertyName("mhoClassification")]
        public MhoClassification MhoClassification { get; set; } = new MhoClassification();
    }
}