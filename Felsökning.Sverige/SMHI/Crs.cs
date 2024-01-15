// ----------------------------------------------------------------------
// <copyright file="Crs.cs" company="Felsökning">
//      Copyright © Felsökning. All rights reserved.
// </copyright>
// <author>John Bailey</author>
// ----------------------------------------------------------------------
namespace Felsökning.Sverige.SMHI
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="Crs"/> class.
    /// </summary>
    public class Crs
    {
        /// <summary>
        ///     Gets or sets the CRS type.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; } = string.Empty;

        /// <summary>
        ///     Gets or sets the properties of the CRS.
        /// </summary>
        [JsonPropertyName("properties")]
        public Properties Properties { get; set; } = new Properties();
    }
}