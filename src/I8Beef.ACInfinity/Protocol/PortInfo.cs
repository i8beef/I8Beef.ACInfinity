using System.Text.Json.Serialization;

namespace I8Beef.ACInfinity.Protocol
{
    /// <summary>
    /// The port.
    /// </summary>
    public class PortInfo
    {
        /// <summary>
        /// Gets or Sets the speak.
        /// </summary>
        [JsonPropertyName("speak")]
        public int? Speak { get; set; }

        /// <summary>
        /// Gets or Sets the device type.
        /// </summary>
        [JsonPropertyName("deviceType")]
        public int? DeviceType { get; set; }

        /// <summary>
        /// Gets or Sets the trend.
        /// </summary>
        [JsonPropertyName("trend")]
        public int Trend { get; set; }

        /// <summary>
        /// Gets or Sets the port.
        /// </summary>
        [JsonPropertyName("port")]
        public int Port { get; set; }

        /// <summary>
        /// Gets or Sets the cur mode.
        /// </summary>
        [JsonPropertyName("curMode")]
        public int CurMode { get; set; }

        /// <summary>
        /// Gets or Sets the remain time.
        /// </summary>
        [JsonPropertyName("remainTime")]
        public int? RemainTime { get; set; }

        /// <summary>
        /// Gets or Sets the mode tye.
        /// </summary>
        [JsonPropertyName("modeTye")]
        public int ModeTye { get; set; }

        /// <summary>
        /// Gets or Sets the online.
        /// </summary>
        [JsonPropertyName("online")]
        public int Online { get; set; }

        /// <summary>
        /// Gets or Sets the port name.
        /// </summary>
        [JsonPropertyName("portName")]
        public string PortName { get; set; } = string.Empty;

        /// <summary>
        /// Gets or Sets the port access.
        /// </summary>
        [JsonPropertyName("portAccess")]
        public object? PortAccess { get; set; }

        /// <summary>
        /// Gets or Sets the port resistance.
        /// </summary>
        [JsonPropertyName("portResistance")]
        public int PortResistance { get; set; }

        /// <summary>
        /// Gets or Sets the is open automation.
        /// </summary>
        [JsonPropertyName("isOpenAutomation")]
        public int IsOpenAutomation { get; set; }

        /// <summary>
        /// Gets or Sets the adv update time.
        /// </summary>
        [JsonPropertyName("advUpdateTime")]
        public string AdvUpdateTime { get; set; } = string.Empty;

        /// <summary>
        /// Gets or Sets the load type.
        /// </summary>
        [JsonPropertyName("loadType")]
        public int LoadType { get; set; }

        /// <summary>
        /// Gets or Sets the load state.
        /// </summary>
        [JsonPropertyName("loadState")]
        public int LoadState { get; set; }

        /// <summary>
        /// Gets or Sets the abnormal state.
        /// </summary>
        [JsonPropertyName("abnormalState")]
        public int AbnormalState { get; set; }

        /// <summary>
        /// Gets or Sets the overcurrent status.
        /// </summary>
        [JsonPropertyName("overcurrentStatus")]
        public int OvercurrentStatus { get; set; }
    }
}
