// ----------------------------------------------------------------------
// <copyright file="WarningsResult.cs" company="Felsökning">
//      Copyright © Felsökning. All rights reserved.
// </copyright>
// <author>John Bailey</author>
// ----------------------------------------------------------------------
namespace Felsökning.Sverige.SMHI
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="WarningsResult"/> class.
    /// </summary>
    public class WarningsResult
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("normalProbability")]
        public bool NormalProbability { get; set; }

        [JsonPropertyName("event")]
        public Event Event { get; set; } = new Event();

        [JsonPropertyName("descriptions")]
        public List<object> Descriptions { get; set; } = new List<object>(0);

        [JsonPropertyName("warningAreas")]
        public List<WarningArea> WarningAreas { get; set; } = new List<WarningArea>(0);
    }
}