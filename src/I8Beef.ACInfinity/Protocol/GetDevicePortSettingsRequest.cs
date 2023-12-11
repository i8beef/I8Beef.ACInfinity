using System.Text.Json.Serialization;

namespace I8Beef.ACInfinity.Protocol
{
    /// <summary>
    /// Get device port settings request.
    /// </summary>
    public class GetDevicePortSettingsRequest
    {
        /// <summary>
        /// Gets or Sets the device id.
        /// </summary>
        [JsonPropertyName("devId")]
        public string DeviceId { get; set; } = string.Empty;

        /// <summary>
        /// Gets or Sets the port.
        /// </summary>
        [JsonPropertyName("port")]
        public int Port { get; set; }
    }
}
