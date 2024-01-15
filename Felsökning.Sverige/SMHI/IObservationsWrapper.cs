namespace Felsökning.Sverige.SMHI
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="IObservationsWrapper"/> interface.
    /// </summary>
    public interface IObservationsWrapper
    {
        /// <summary>
        ///     Gets the <see cref="Resource"/> objects that are derived from the <see cref="Parameter"/> response in the SMHI observations API.
        /// </summary>
        /// <returns>An awaitable <see cref="List{T}"/> of <see cref="Resource"/>.</returns>
        Task<List<Resource>> GetParameterResourcesAsync();

        /// <summary>
        ///     Gets the <see cref="Station"/> objects that are derived from the <see cref="StationData"/> response in the SMHI observations API.
        /// </summary>
        /// <param name="resource">The <see cref="Resource"/> to target for the station.</param>
        /// <returns>An awaitable <see cref="List{T}"/> of <see cref="Station"/>.</returns>
        Task<List<Station>> GetStationsBasedOnResourceAsync(Resource resource);

        /// <summary>
        ///     Gets the <typeparamref name="T"/> object returned from the given <see cref="Resource"/> from the <see cref="Station"/>.
        /// </summary>
        /// <typeparam name="T">The <typeparamref name="T"/> to return.</typeparam>
        /// <param name="resource"></param>
        /// <param name="station"></param>
        Task<T> GetResourceDataFromStationAsync<T>(Resource resource, Station station);
    }
}