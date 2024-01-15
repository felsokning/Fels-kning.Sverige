// ----------------------------------------------------------------------
// <copyright file="WarningsWrapper.cs" company="Felsökning">
//      Copyright © Felsökning. All rights reserved.
// </copyright>
// <author>John Bailey</author>
// ----------------------------------------------------------------------
namespace Felsökning.Sverige.SMHI
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="WarningsWrapper"/> class.
    /// </summary>
    /// <inheritdoc cref="HttpBase"/>
    public class WarningsWrapper : HttpBase
    {
        private readonly string _apiVersion;
        private const string _baseAddress = "https://opendata-download-warnings.smhi.se/ibww/api/version/";

        /// <summary>
        ///     Initializes a new instance of the <see cref="WarningsWrapper"/> class.
        /// </summary>
        /// <param name="apiVersion">
        /// The API Version to use for the Warnings endpoint.
        /// <para>NOTE: This does NOT conform to symver.</para>
        /// </param>
        /// <inheritdoc cref="HttpBase"/>
        public WarningsWrapper(string apiVersion = "1")
            : base(HttpVersion.Version11, "Felsökning.Sverige")
        {
            _apiVersion = apiVersion;
            this.HttpClient.BaseAddress = new Uri(_baseAddress);
        }

        /// <summary>
        ///     Gets the most recently published Warnings from the SMHI API.
        /// </summary>
        /// <returns>A <see cref="Task{TResult}"/> of <see cref="WarningsResult"/></returns>
        /// <exception cref="StatusException">An error occurred on the underlying HTTP call[s].</exception>
        public async Task<List<WarningsResult>> GetRecentWarningsAsync()
        {
            var apiEntry = await this.HttpClient.GetAsync<WarningsApiEntry>($"{_apiVersion}.json");
            return await this.HttpClient.GetAsync<List<WarningsResult>>(apiEntry.Warning.Href);
        }
    }
}
