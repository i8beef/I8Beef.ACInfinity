using System.Text.Json.Serialization;

namespace I8Beef.ACInfinity.Protocol
{
    /// <summary>
    /// Get all device request.
    /// </summary>
    public class GetAllDeviceRequest
    {
        /// <summary>
        /// Gets or Sets the user id.
        /// </summary>
        [JsonPropertyName("userId")]
        public string UserId { get; set; } = string.Empty;
    }
}
