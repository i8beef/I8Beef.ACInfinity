using System.Collections.Generic;

namespace I8Beef.ACInfinity.Protocol
{
    /// <summary>
    /// Response base class.
    /// </summary>
    public class ResponseBase
    {
        /// <summary>
        /// Response data.
        /// </summary>
        public IDictionary<string, object> Data { get; set; } = new Dictionary<string, object>();
    }
}
