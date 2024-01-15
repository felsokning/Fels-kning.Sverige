// ----------------------------------------------------------------------
// <copyright file="WarningArea.cs" company="Felsökning">
//      Copyright © Felsökning. All rights reserved.
// </copyright>
// <author>John Bailey</author>
// ----------------------------------------------------------------------
namespace Felsökning.Sverige.SMHI
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="WarningArea"/> class.
    /// </summary>
    public class WarningArea
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("approximateStart")]
        public DateTime ApproximateStart { get; set; }

        [JsonPropertyName("published")]
        public DateTime Published { get; set; }

        [JsonPropertyName("normalProbability")]
        public bool NormalProbability { get; set; }

        [JsonPropertyName("areaName")]
        public AreaName AreaName { get; set; }

        [JsonPropertyName("warningLevel")]
        public WarningLevel WarningLevel { get; set; }

        [JsonPropertyName("eventDescription")]
        public EventDescription EventDescription { get; set; }

        [JsonPropertyName("affectedAreas")]
        public List<AffectedArea> AffectedAreas { get; set; }

        [JsonPropertyName("descriptions")]
        public List<Description> Descriptions { get; set; }

        [JsonPropertyName("area")]
        public Area Area { get; set; }

        [JsonPropertyName("approximateEnd")]
        public DateTime? ApproximateEnd { get; set; }
    }
}
