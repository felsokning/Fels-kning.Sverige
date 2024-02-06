namespace Felsökning.Sverige.ArlandaExpress
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="City"/> enumeration.
    /// </summary>
    public enum City
    {
        /// <summary>
        ///     Arlanda Airport
        /// </summary>
        [JsonPropertyName("arlanda")]
        [EnumMember(Value = "arlanda")]
        Arlanda,

        /// <summary>
        ///     Stockholm Centralstation
        /// </summary>
        [JsonPropertyName("arlanda")]
        [EnumMember(Value = "stockholm")]
        Stockholm,
    }
}