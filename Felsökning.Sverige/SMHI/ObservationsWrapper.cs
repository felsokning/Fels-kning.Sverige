// ----------------------------------------------------------------------
// <copyright file="ObservationsWrapper.cs" company="Felsökning">
//      Copyright © Felsökning. All rights reserved.
// </copyright>
// <author>John Bailey</author>
// ----------------------------------------------------------------------
namespace Felsökning.Sverige.SMHI
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="ObservationsWrapper"/> class.
    /// </summary>
    /// <inheritdoc cref="HttpBase"/>
    public class ObservationsWrapper : HttpBase, IObservationsWrapper
    {
        private const string _baseAddress = "https://opendata-download-metobs.smhi.se/api/version/";

        /// <summary>
        ///     Initializes a new instance of the <see cref="ObservationsWrapper"/> class.
        /// </summary>
        /// <inheritdoc cref="HttpBase"/>
        public ObservationsWrapper(string apiVersion = "1.0")
            : base(HttpVersion.Version11, "Felsökning.Sverige")
        {
            HttpClient.BaseAddress = new Uri($"{_baseAddress}{apiVersion}/");
        }

        /// <summary>
        ///     Gets the <see cref="Resource"/> objects that are derived from the <see cref="Parameter"/> response in the SMHI observations API.
        /// </summary>
        /// <returns>An awaitable <see cref="List{T}"/> of <see cref="Resource"/>.</returns>
        /// <exception cref="StatusException">An error occurred on the underlying HTTP call[s].</exception>
        public async Task<List<Resource>> GetParameterResourcesAsync()
        {
            this.HttpClient.GenerateNewRequestId();
            var url = "parameter.json";
            var parameter = await this.HttpClient.GetAsync<Parameter>(url);
            return parameter.Resource;
        }

        /// <summary>
        ///     Gets the <see cref="Station"/> objects that are derived from the <see cref="StationData"/> response in the SMHI observations API.
        /// </summary>
        /// <param name="resource">The <see cref="Resource"/> to target for the station.</param>
        /// <returns>An awaitable <see cref="List{T}"/> of <see cref="Station"/>.</returns>
        /// <exception cref="StatusException">An error occurred on the underlying HTTP call[s].</exception>
        public async Task<List<Station>> GetStationsBasedOnResourceAsync(Resource resource)
        {
            var url = $"parameter/{resource.Key}/station.json";
            var stationData =  await this.HttpClient.GetAsync<StationData>(url);
            return stationData.Station;
        }

        /// <summary>
        ///     Gets the <typeparamref name="T"/> object returned from the given <see cref="Resource"/> from the <see cref="Station"/>.
        /// </summary>
        /// <typeparam name="T">The <typeparamref name="T"/> to return.</typeparam>
        /// <param name="resource"></param>
        /// <param name="station"></param>
        /// <returns></returns>
        /// <exception cref="StatusException">An error occurred on the underlying HTTP call[s].</exception>
        public async Task<T> GetResourceDataFromStationAsync<T>(Resource resource, Station station)
        {
            var url = $"parameter/{resource.Key}/station/{station.Id}/period/latest-hour/data.json";
            return await this.HttpClient.GetAsync<T>(url);
        }
    }
}