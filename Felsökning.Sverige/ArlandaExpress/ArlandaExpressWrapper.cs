namespace Felsökning.Sverige.ArlandaExpress
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="ArlandaExpressWrapper"/>, which is used to query for departure times for Arlanda Express.
    /// </summary>
    /// <inheritdoc cref="HttpBase"/>
    public class ArlandaExpressWrapper : HttpBase, IArlandaExpressWrapper
    {
        private const string _baseAddress = "https://api.atrain.se/v1/ecom/departures/upcomingDepartures/";

        /// <summary>
        ///     Initializes a new instance of the <see cref="ArlandaExpressWrapper"/>, which is used to query for departure times for Arlanda Express.
        /// </summary>
        /// <inheritdoc cref="HttpBase"/>
        public ArlandaExpressWrapper()
            : base(HttpVersion.Version20, "Felsökning.Sverige")
        {
            this.HttpClient.BaseAddress = new Uri(_baseAddress);
        }

        /// <summary>
        ///     Obtains the list of departures for the given <see cref="City"/>.
        /// </summary>
        /// <param name="city">The <see cref="City"/> the departures are from.</param>
        /// <returns>An awaitable <see cref="Task{TResult}"/> of <see cref="List{T}"/> of <see cref="Departure"/>.</returns>
        public async Task<List<Departure>> GetDeparturesAsync(City city)
        {
            var targetCity = city.ToString().ToLower();
            return await this.HttpClient.GetAsync<List<Departure>>(targetCity);
        }
    }
}