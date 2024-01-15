// ----------------------------------------------------------------------
// <copyright file="EventDescription.cs" company="Felsökning">
//      Copyright © Felsökning. All rights reserved.
// </copyright>
// <author>John Bailey</author>
// ----------------------------------------------------------------------
namespace Felsökning.Sverige.SMHI
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="EventDescription"/> class.
    /// </summary>
    public class EventDescription
    {
        /// <summary>
        ///     Gets or sets the Event Description in Swedish.
        /// </summary>
        [JsonPropertyName("sv")]
        public string Svenska { get; set; } = string.Empty;

        /// <summary>
        ///     Gets or sets the Event Description in English.
        /// </summary>
        [JsonPropertyName("en")]
        public string English { get; set; } = string.Empty;

        /// <summary>
        ///     Gets or sets the Event Description Code.
        /// </summary>
        [JsonPropertyName("code")]
        public string Code { get; set; } = string.Empty;
    }
}