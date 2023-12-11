using System.Text.Json.Serialization;

namespace I8Beef.ACInfinity.Protocol
{
    /// <summary>
    /// Device model.
    /// </summary>
    public class Device
    {
        /// <summary>
        /// Gets or Sets the dev id.
        /// </summary>
        [JsonPropertyName("devId")]
        public string DevId { get; set; } = string.Empty;

        /// <summary>
        /// Gets or Sets the dev code.
        /// </summary>
        [JsonPropertyName("devCode")]
        public string DevCode { get; set; } = string.Empty;

        /// <summary>
        /// Gets or Sets the dev name.
        /// </summary>
        [JsonPropertyName("devName")]
        public string DevName { get; set; } = string.Empty;

        /// <summary>
        /// Gets or Sets the dev type.
        /// </summary>
        [JsonPropertyName("devType")]
        public int DevType { get; set; }

        /// <summary>
        /// Gets or Sets the dev access time.
        /// </summary>
        [JsonPropertyName("devAccesstime")]
        public int? DevAccessTime { get; set; }

        /// <summary>
        /// Gets or Sets the dev port count.
        /// </summary>
        [JsonPropertyName("devPortCount")]
        public int DevPortCount { get; set; }

        /// <summary>
        /// Gets or Sets the dev offtime.
        /// </summary>
        [JsonPropertyName("devOfftime")]
        public int? DevOfftime { get; set; }

        /// <summary>
        /// Gets or Sets the dev mac addr.
        /// </summary>
        [JsonPropertyName("devMacAddr")]
        public string DevMacAddr { get; set; } = string.Empty;

        /// <summary>
        /// Gets or Sets the dev version.
        /// </summary>
        [JsonPropertyName("devVersion")]
        public int DevVersion { get; set; }

        /// <summary>
        /// Gets or Sets the online.
        /// </summary>
        [JsonPropertyName("online")]
        public int Online { get; set; }

        /// <summary>
        /// Gets or Sets the is share.
        /// </summary>
        [JsonPropertyName("isShare")]
        public int IsShare { get; set; }

        /// <summary>
        /// Gets or Sets the dev external list.
        /// </summary>
        [JsonPropertyName("devExternalList")]
        public object? DevExternalList { get; set; }

        /// <summary>
        /// Gets or Sets the device info.
        /// </summary>
        [JsonPropertyName("deviceInfo")]
        public DeviceInfo DeviceInfo { get; set; } = default!;

        /// <summary>
        /// Gets or Sets the app email.
        /// </summary>
        [JsonPropertyName("appEmail")]
        public string AppEmail { get; set; } = string.Empty;

        /// <summary>
        /// Gets or Sets the dev time zone.
        /// </summary>
        [JsonPropertyName("devTimeZone")]
        public string? DevTimeZone { get; set; }

        /// <summary>
        /// Gets or Sets the create time.
        /// </summary>
        [JsonPropertyName("createTime")]
        public string? CreateTime { get; set; }

        /// <summary>
        /// Gets or Sets the time GMT.
        /// </summary>
        [JsonPropertyName("timeGMT")]
        public string? TimeGMT { get; set; }

        /// <summary>
        /// Gets or Sets the time zone.
        /// </summary>
        [JsonPropertyName("timeZone")]
        public string? TimeZone { get; set; }

        /// <summary>
        /// Gets or Sets the firmware version.
        /// </summary>
        [JsonPropertyName("firmwareVersion")]
        public string FirmwareVersion { get; set; } = string.Empty;

        /// <summary>
        /// Gets or Sets the hardware version.
        /// </summary>
        [JsonPropertyName("hardwareVersion")]
        public string HardwareVersion { get; set; } = string.Empty;

        /// <summary>
        /// Gets or Sets the work mode.
        /// </summary>
        [JsonPropertyName("workMode")]
        public int WorkMode { get; set; }

        /// <summary>
        /// Gets or Sets the zone id.
        /// </summary>
        [JsonPropertyName("zoneId")]
        public string ZoneId { get; set; } = string.Empty;

        /// <summary>
        /// Gets or Sets the wifi name.
        /// </summary>
        [JsonPropertyName("wifiName")]
        public string? WifiName { get; set; }
    }
}
