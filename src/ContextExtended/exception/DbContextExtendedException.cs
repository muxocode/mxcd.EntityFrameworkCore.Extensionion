using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace mxcd.dbContextExtended.exception
{
    /// <summary>
    /// Exception on DbContextExtended
    /// </summary>
    public class DbContextExtendedException:System.Exception
    {
        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="message">message</param>
        /// <param name="oEx">exception</param>
        /// <param name="logger">logger</param>
        public DbContextExtendedException(string message, Exception oEx, ILogger<Exception> logger = null) : base(message, oEx)
        {
            logger?.LogError("Error on DbContextExtended", oEx);
        }
    }
}
