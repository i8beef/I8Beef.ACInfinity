using System.Text.Json.Serialization;

namespace I8Beef.ACInfinity.Protocol
{
    /// <summary>
    /// Login request.
    /// </summary>
    public class LoginRequest
    {
        /// <summary>
        /// Gets or Sets the app email.
        /// </summary>
        [JsonPropertyName("appEmail")]
        public string AppEmail { get; set; } = string.Empty;

        /// <summary>
        /// Gets or Sets the app password.
        /// </summary>
        [JsonPropertyName("appPasswordl")]
        public string AppPasswordL { get; set; } = string.Empty;
    }
}
