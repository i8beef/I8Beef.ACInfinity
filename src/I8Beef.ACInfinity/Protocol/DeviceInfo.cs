using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace I8Beef.ACInfinity.Protocol
{
    /// <summary>
    /// The device info.
    /// </summary>
    public class DeviceInfo
    {

        /// <summary>
        /// Gets or Sets the dev id.
        /// </summary>
        [JsonPropertyName("devId")]
        public long DevId { get; set; }

        /// <summary>
        /// Gets or Sets the temperature.
        /// </summary>
        [JsonPropertyName("temperature")]
        public int? Temperature { get; set; }

        /// <summary>
        /// Gets or Sets the temperature F.
        /// </summary>
        [JsonPropertyName("temperatureF")]
        public int? TemperatureF { get; set; }

        /// <summary>
        /// Gets or Sets the humidity.
        /// </summary>
        [JsonPropertyName("humidity")]
        public int? Humidity { get; set; }

        /// <summary>
        /// Gets or Sets the T trend.
        /// </summary>
        [JsonPropertyName("tTrend")]
        public int? TTrend { get; set; }

        /// <summary>
        /// Gets or Sets the H trend.
        /// </summary>
        [JsonPropertyName("hTrend")]
        public int? HTrend { get; set; }

        /// <summary>
        /// Gets or Sets the unit.
        /// </summary>
        [JsonPropertyName("unit")]
        public int? Unit { get; set; }

        /// <summary>
        /// Gets or Sets the speak.
        /// </summary>
        [JsonPropertyName("speak")]
        public int? Speak { get; set; }

        /// <summary>
        /// Gets or Sets the trend.
        /// </summary>
        [JsonPropertyName("trend")]
        public int? Trend { get; set; }

        /// <summary>
        /// Gets or Sets the cur mode.
        /// </summary>
        [JsonPropertyName("curMode")]
        public int? CurMode { get; set; }

        /// <summary>
        /// Gets or Sets the remain time.
        /// </summary>
        [JsonPropertyName("remainTime")]
        public object? RemainTime { get; set; }

        /// <summary>
        /// Gets or Sets the mode tye.
        /// </summary>
        [JsonPropertyName("modeTye")]
        public int? ModeTye { get; set; }

        /// <summary>
        /// Gets or Sets the adv trigger info.
        /// </summary>
        [JsonPropertyName("advTriggerInfo")]
        public object? AdvTriggerInfo { get; set; }

        /// <summary>
        /// Gets or Sets the notification trigger.
        /// </summary>
        [JsonPropertyName("notificationTrigger")]
        public object? NotificationTrigger { get; set; }

        /// <summary>
        /// Gets or Sets the alert trigger.
        /// </summary>
        [JsonPropertyName("alertTrigger")]
        public object? AlertTrigger { get; set; }

        /// <summary>
        /// Gets or Sets the online.
        /// </summary>
        [JsonPropertyName("online")]
        public int Online { get; set; }

        /// <summary>
        /// Gets or Sets the lk type.
        /// </summary>
        [JsonPropertyName("lkType")]
        public object? LkType { get; set; }

        /// <summary>
        /// Gets or Sets the end time.
        /// </summary>
        [JsonPropertyName("endTime")]
        public int? EndTime { get; set; }

        /// <summary>
        /// Gets or Sets the master.
        /// </summary>
        [JsonPropertyName("master")]
        public int Master { get; set; }

        /// <summary>
        /// Gets or Sets the master port.
        /// </summary>
        [JsonPropertyName("masterPort")]
        public int MasterPort { get; set; }

        /// <summary>
        /// Gets or Sets the all port status.
        /// </summary>
        [JsonPropertyName("allPortStatus")]
        public int? AllPortStatus { get; set; }

        /// <summary>
        /// Gets or Sets the ports.
        /// </summary>
        [JsonPropertyName("ports")]
        public IList<PortInfo> Ports { get; set; } = default!;

        /// <summary>
        /// Gets or Sets the log create time.
        /// </summary>
        [JsonPropertyName("logCreateTime")]
        public string? LogCreateTime { get; set; }

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
        /// Gets or Sets the device info I.
        /// </summary>
        [JsonPropertyName("deviceInfoI")]
        public object? DeviceInfoI { get; set; }

        /// <summary>
        /// Gets or Sets the temp compare.
        /// </summary>
        [JsonPropertyName("tempCompare")]
        public int TempCompare { get; set; }

        /// <summary>
        /// Gets or Sets the humi compare.
        /// </summary>
        [JsonPropertyName("humiCompare")]
        public int HumiCompare { get; set; }

        /// <summary>
        /// Gets or Sets the ectds type.
        /// </summary>
        [JsonPropertyName("ectdsType")]
        public int? EctdsType { get; set; }

        /// <summary>
        /// Gets or Sets the tds unit.
        /// </summary>
        [JsonPropertyName("tdsUnit")]
        public int? TdsUnit { get; set; }

        /// <summary>
        /// Gets or Sets the ec unit.
        /// </summary>
        [JsonPropertyName("ecUnit")]
        public int? EcUnit { get; set; }

        /// <summary>
        /// Gets or Sets the sensor count.
        /// </summary>
        [JsonPropertyName("sensorCount")]
        public int? SensorCount { get; set; }

        /// <summary>
        /// Gets or Sets the sensors.
        /// </summary>
        [JsonPropertyName("sensors")]
        public IList<object>? Sensors { get; set; }

        /// <summary>
        /// Gets or Sets the overcurrent status.
        /// </summary>
        [JsonPropertyName("overcurrentStatus")]
        public int OvercurrentStatus { get; set; }

        /// <summary>
        /// Gets or Sets the vpdnums.
        /// </summary>
        [JsonPropertyName("vpdnums")]
        public int? Vpdnums { get; set; }

        /// <summary>
        /// Gets or Sets the vpdstatus.
        /// </summary>
        [JsonPropertyName("vpdstatus")]
        public int? Vpdstatus { get; set; }
    }
}
