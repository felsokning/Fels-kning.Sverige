namespace Felsökning.Sverige.SMHI
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="Station"/> class.
    /// </summary>
    public class Station
    {
        /// <summary>
        ///     Gets or sets the station identifier
        /// </summary>
        [JsonPropertyName("key")]
        public string Key { get; set; } = string.Empty;

        /// <summary>
        ///     Gets or sets when the data for the station is latest updated.
        /// </summary>
        [JsonPropertyName("updated")]
        public object Updated { get; set; } = new object();

        /// <summary>
        ///     Gets or sets the name of the station.
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; } = string.Empty;

        /// <summary>
        ///     Gets or sets the description of the station.
        /// </summary>
        [JsonPropertyName("summary")]
        public string Summary { get; set; } = string.Empty;

        /// <summary>
        ///     Gets or sets the links of the station.
        /// </summary>
        [JsonPropertyName("link")]
        public List<Link> Link { get; set; } = new List<Link>(0);

        /// <summary>
        ///     Gets or sets the name of the station.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        ///     Gets or sets who owns the station. 
        ///     <para>Can be SMHI, Icke namngiven ägare, Swedavia and others.</para>
        /// </summary>
        [JsonPropertyName("owner")]
        public string Owner { get; set; } = string.Empty;

        /// <summary>
        ///     Gets or sets the owner category of the station.
        /// </summary>
        [JsonPropertyName("ownerCategory")]
        public string OwnerCategory { get; set; } = string.Empty;

        /// <summary>
        ///     Gets or sets which measuring network the station belongs to. 
        ///     <para>Can be CORE or ADDITIONAL.</para>
        ///     <para>CORE stations are monitored, inspected and maintained by SMHI.</para> 
        ///     <para>Values reported from CORE stations are quality checked and corrected.</para>
        ///     <para>Values from ADDITIONAL stations are not quality checked and the stations are not inspected by SMHI.</para>
        /// </summary>
        [JsonPropertyName("measuringStations")]
        public string MeasuringStations { get; set; } = string.Empty;

        /// <summary>
        ///     Gets or sets the id of the station.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }

        /// <summary>
        ///     Gets or sets the height of the station.
        /// </summary>
        [JsonPropertyName("height")]
        public double Height { get; set; }

        /// <summary>
        ///     Gets or sets the latitude of the station.
        /// </summary>
        [JsonPropertyName("latitude")]
        public double Latitude { get; set; }

        /// <summary>
        ///     Gets or sets the longitude of the station.
        /// </summary>
        [JsonPropertyName("longitude")]
        public double Longitude { get; set; }

        /// <summary>
        ///     Gets or sets is the station still "live"?
        /// </summary>
        [JsonPropertyName("active")]
        public bool Active { get; set; }

        /// <summary>
        ///     Gets or sets the from of the station.
        /// </summary>
        [JsonPropertyName("from")]
        public object From { get; set; } = new object();

        /// <summary>
        ///     Gets or sets the to of the station.
        /// </summary>
        [JsonPropertyName("to")]
        public object To { get; set; } = new object();
    }
}