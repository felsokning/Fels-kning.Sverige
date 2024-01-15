﻿// ----------------------------------------------------------------------
// <copyright file="IWarningsWrapper.cs" company="Felsökning">
//      Copyright © Felsökning. All rights reserved.
// </copyright>
// <author>John Bailey</author>
// ----------------------------------------------------------------------
namespace Felsökning.Sverige.SMHI
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="IWarningsWrapper"/> interface.
    /// </summary>
    public interface IWarningsWrapper
    {
        /// <summary>
        ///     Gets the most recently published Warnings from the SMHI API.
        /// </summary>
        /// <returns>A <see cref="Task{TResult}"/> of <see cref="WarningsResult"/></returns>
        /// <exception cref="StatusException">An error occurred on the underlying HTTP call[s].</exception>
        Task<List<WarningsResult>> GetRecentWarningsAsync();
    }
}