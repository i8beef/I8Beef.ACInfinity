using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace I8Beef.ACInfinity.Protocol
{
    /// <summary>
    /// The device settings.
    /// </summary>
    public class DeviceSettings
    {
        /// <summary>
        /// Gets or Sets the set id.
        /// </summary>
        [JsonPropertyName("setId")]
        public string? SetId { get; set; }

        /// <summary>
        /// Gets or Sets the dev id.
        /// </summary>
        [JsonPropertyName("devId")]
        public string DevId { get; set; } = string.Empty;

        /// <summary>
        /// Gets or Sets the external port.
        /// </summary>
        [JsonPropertyName("externalPort")]
        public int? ExternalPort { get; set; }

        /// <summary>
        /// Gets or Sets the dev light.
        /// </summary>
        [JsonPropertyName("devLight")]
        public int? DevLight { get; set; }

        /// <summary>
        /// Gets or Sets the has backlight switch.
        /// </summary>
        [JsonPropertyName("hasBacklightSwitch")]
        public int? HasBacklightSwitch { get; set; }

        /// <summary>
        /// Gets or Sets the backlight switch.
        /// </summary>
        [JsonPropertyName("backlightSwitch")]
        public int? BacklightSwitch { get; set; }

        /// <summary>
        /// Gets or Sets the dev ct.
        /// </summary>
        [JsonPropertyName("devCt")]
        public int? DevCt { get; set; }

        /// <summary>
        /// Gets or Sets the dev cth.
        /// </summary>
        [JsonPropertyName("devCth")]
        public int? DevCth { get; set; }

        /// <summary>
        /// Gets or Sets the dev ch.
        /// </summary>
        [JsonPropertyName("devCh")]
        public int? DevCh { get; set; }

        /// <summary>
        /// Gets or Sets the dev tth.
        /// </summary>
        [JsonPropertyName("devTth")]
        public int? DevTth { get; set; }

        /// <summary>
        /// Gets or Sets the dev tt.
        /// </summary>
        [JsonPropertyName("devTt")]
        public int? DevTt { get; set; }

        /// <summary>
        /// Gets or Sets the dev th.
        /// </summary>
        [JsonPropertyName("devTh")]
        public int? DevTh { get; set; }

        /// <summary>
        /// Gets or Sets the dev company.
        /// </summary>
        [JsonPropertyName("devCompany")]
        public int? DevCompany { get; set; }

        /// <summary>
        /// Gets or Sets the vpd cth.
        /// </summary>
        [JsonPropertyName("vpdCth")]
        public int? VpdCth { get; set; }

        /// <summary>
        /// Gets or Sets the vpd ct.
        /// </summary>
        [JsonPropertyName("vpdCt")]
        public int? VpdCt { get; set; }

        /// <summary>
        /// Gets or Sets the vpd transition.
        /// </summary>
        [JsonPropertyName("vpdTransition")]
        public int? VpdTransition { get; set; }

        /// <summary>
        /// Gets or Sets the dev bth.
        /// </summary>
        [JsonPropertyName("devBth")]
        public int? DevBth { get; set; }

        /// <summary>
        /// Gets or Sets the dev bt.
        /// </summary>
        [JsonPropertyName("devBt")]
        public int? DevBt { get; set; }

        /// <summary>
        /// Gets or Sets the dev bh.
        /// </summary>
        [JsonPropertyName("devBh")]
        public int? DevBh { get; set; }

        /// <summary>
        /// Gets or Sets the dev bvpd.
        /// </summary>
        [JsonPropertyName("devBvpd")]
        public int? DevBvpd { get; set; }

        /// <summary>
        /// Gets or Sets the is flag.
        /// </summary>
        [JsonPropertyName("isFlag")]
        public int? IsFlag { get; set; }

        /// <summary>
        /// Gets or Sets the on time switch.
        /// </summary>
        [JsonPropertyName("onTimeSwitch")]
        public int? OnTimeSwitch { get; set; }

        /// <summary>
        /// Gets or Sets the on time.
        /// </summary>
        [JsonPropertyName("onTime")]
        public int? OnTime { get; set; }

        /// <summary>
        /// Gets or Sets the sensors.
        /// </summary>
        [JsonPropertyName("sensors")]
        public IList<int?> Sensors { get; set; } = default!;

        /// <summary>
        /// Gets or Sets the is open dose time.
        /// </summary>
        [JsonPropertyName("isOpenDoseTime")]
        public int? IsOpenDoseTime { get; set; }

        /// <summary>
        /// Gets or Sets the on dose time.
        /// </summary>
        [JsonPropertyName("onDoseTime")]
        public int? OnDoseTime { get; set; }

        /// <summary>
        /// Gets or Sets the off dose time.
        /// </summary>
        [JsonPropertyName("offDoseTime")]
        public int? OffDoseTime { get; set; }

        /// <summary>
        /// Gets or Sets the is on min max time.
        /// </summary>
        [JsonPropertyName("isOnMinMaxTime")]
        public int? IsOnMinMaxTime { get; set; }

        /// <summary>
        /// Gets or Sets the on min time.
        /// </summary>
        [JsonPropertyName("onMinTime")]
        public int? OnMinTime { get; set; }

        /// <summary>
        /// Gets or Sets the on max time.
        /// </summary>
        [JsonPropertyName("onMaxTime")]
        public int? OnMaxTime { get; set; }

        /// <summary>
        /// Gets or Sets the ec or tds.
        /// </summary>
        [JsonPropertyName("ecOrTds")]
        public int? EcOrTds { get; set; }

        /// <summary>
        /// Gets or Sets the ec unit.
        /// </summary>
        [JsonPropertyName("ecUnit")]
        public int? EcUnit { get; set; }

        /// <summary>
        /// Gets or Sets the tds unit.
        /// </summary>
        [JsonPropertyName("tdsUnit")]
        public int? TdsUnit { get; set; }

        /// <summary>
        /// Gets or Sets the dual zone switch.
        /// </summary>
        [JsonPropertyName("dualZoneSwitch")]
        public int? DualZoneSwitch { get; set; }

        /// <summary>
        /// Gets or Sets the photo cell switch.
        /// </summary>
        [JsonPropertyName("photoCellSwitch")]
        public int? PhotoCellSwitch { get; set; }
    }
}
