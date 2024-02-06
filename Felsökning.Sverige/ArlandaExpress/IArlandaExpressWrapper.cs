namespace Felsökning.Sverige.ArlandaExpress
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="IArlandaExpressWrapper"/> interface.
    /// </summary>
    public interface IArlandaExpressWrapper
    {
        /// <summary>
        ///     Obtains the list of departures for the given <see cref="City"/>.
        /// </summary>
        /// <param name="city">The <see cref="City"/> the departures are from.</param>
        /// <returns>An awaitable <see cref="Task{TResult}"/> of <see cref="List{T}"/> of <see cref="Departure"/>.</returns>
        Task<List<Departure>> GetDeparturesAsync(City city);
    }
}