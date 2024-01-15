// ----------------------------------------------------------------------
// <copyright file="Geometry.cs" company="Felsökning">
//      Copyright © Felsökning. All rights reserved.
// </copyright>
// <author>John Bailey</author>
// ----------------------------------------------------------------------
namespace Felsökning.Sverige.SMHI
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="Geometry"/> class.
    /// </summary>
    public class Geometry
    {
        /// <summary>
        ///     Gets or sets the type of the Geometry.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; } = string.Empty;

        /// <summary>
        ///     Gets or sets the geometrical coordinates.
        /// </summary>
        [JsonPropertyName("coordinates")]
        public List<List<List<object>>> Coordinates { get; set; } = new List<List<List<object>>>(0);
    }
}