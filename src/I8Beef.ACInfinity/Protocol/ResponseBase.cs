using System.Text.Json.Serialization;

namespace I8Beef.ACInfinity.Protocol
{
    /// <summary>
    /// Response base class.
    /// </summary>
    public class ResponseBase<TData>
        where TData : class
    {
        /// <summary>
        /// Response code.
        /// </summary>
        [JsonPropertyName("code")]
        public int Code { get; set; }

        /// <summary>
        /// Response messsage.
        /// </summary>
        [JsonPropertyName("msg")]
        public string Message { get; set; } = string.Empty;

        /// <summary>
        /// Response data.
        /// </summary>
        [JsonPropertyName("data")]
        public TData Data { get; set; } = default!;
    }
}
