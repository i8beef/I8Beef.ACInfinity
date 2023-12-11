using System.Text.Json.Serialization;

namespace I8Beef.ACInfinity.Protocol
{
    /// <summary>
    /// The port settings.
    /// </summary>
    public class PortSettings
    {
        /// <summary>
        /// Gets or Sets the mode setid.
        /// </summary>
        [JsonPropertyName("modeSetid")]
        public string ModeSetid { get; set; } = string.Empty;

        /// <summary>
        /// Gets or Sets the dev id.
        /// </summary>
        [JsonPropertyName("devId")]
        public string DevId { get; set; } = string.Empty;

        /// <summary>
        /// Gets or Sets the external port.
        /// </summary>
        [JsonPropertyName("externalPort")]
        public int ExternalPort { get; set; }

        /// <summary>
        /// Gets or Sets the off spead.
        /// </summary>
        [JsonPropertyName("offSpead")]
        public int? OffSpead { get; set; }

        /// <summary>
        /// Gets or Sets the on spead.
        /// </summary>
        [JsonPropertyName("onSpead")]
        public int? OnSpead { get; set; }

        /// <summary>
        /// Gets or Sets the active ht.
        /// </summary>
        [JsonPropertyName("activeHt")]
        public int? ActiveHt { get; set; }

        /// <summary>
        /// Gets or Sets the dev ht.
        /// </summary>
        [JsonPropertyName("devHt")]
        public int? DevHt { get; set; }

        /// <summary>
        /// Gets or Sets the dev htf.
        /// </summary>
        [JsonPropertyName("devHtf")]
        public int? DevHtf { get; set; }

        /// <summary>
        /// Gets or Sets the dev ltf.
        /// </summary>
        [JsonPropertyName("devLtf")]
        public int? DevLtf { get; set; }

        /// <summary>
        /// Gets or Sets the active lt.
        /// </summary>
        [JsonPropertyName("activeLt")]
        public int? ActiveLt { get; set; }

        /// <summary>
        /// Gets or Sets the dev lt.
        /// </summary>
        [JsonPropertyName("devLt")]
        public int? DevLt { get; set; }

        /// <summary>
        /// Gets or Sets the active hh.
        /// </summary>
        [JsonPropertyName("activeHh")]
        public int? ActiveHh { get; set; }

        /// <summary>
        /// Gets or Sets the dev hh.
        /// </summary>
        [JsonPropertyName("devHh")]
        public int? DevHh { get; set; }

        /// <summary>
        /// Gets or Sets the active lh.
        /// </summary>
        [JsonPropertyName("activeLh")]
        public int? ActiveLh { get; set; }

        /// <summary>
        /// Gets or Sets the dev lh.
        /// </summary>
        [JsonPropertyName("devLh")]
        public int? DevLh { get; set; }

        /// <summary>
        /// Gets or Sets the acitve timer on.
        /// </summary>
        [JsonPropertyName("acitveTimerOn")]
        public int? AcitveTimerOn { get; set; }

        /// <summary>
        /// Gets or Sets the acitve timer off.
        /// </summary>
        [JsonPropertyName("acitveTimerOff")]
        public int? AcitveTimerOff { get; set; }

        /// <summary>
        /// Gets or Sets the active cycle on.
        /// </summary>
        [JsonPropertyName("activeCycleOn")]
        public int? ActiveCycleOn { get; set; }

        /// <summary>
        /// Gets or Sets the active cycle off.
        /// </summary>
        [JsonPropertyName("activeCycleOff")]
        public int? ActiveCycleOff { get; set; }

        /// <summary>
        /// Gets or Sets the sched start time.
        /// </summary>
        [JsonPropertyName("schedStartTime")]
        public int? SchedStartTime { get; set; }

        /// <summary>
        /// Gets or Sets the sched endt time.
        /// </summary>
        [JsonPropertyName("schedEndtTime")]
        public int? SchedEndtTime { get; set; }

        /// <summary>
        /// Gets or Sets the surplus.
        /// </summary>
        [JsonPropertyName("surplus")]
        public int? Surplus { get; set; }

        /// <summary>
        /// Gets or Sets the mode type.
        /// </summary>
        [JsonPropertyName("modeType")]
        public int? ModeType { get; set; }

        /// <summary>
        /// Gets or Sets the active ht vpd.
        /// </summary>
        [JsonPropertyName("activeHtVpd")]
        public int? ActiveHtVpd { get; set; }

        /// <summary>
        /// Gets or Sets the active lt vpd.
        /// </summary>
        [JsonPropertyName("activeLtVpd")]
        public int? ActiveLtVpd { get; set; }

        /// <summary>
        /// Gets or Sets the active ht vpd nums.
        /// </summary>
        [JsonPropertyName("activeHtVpdNums")]
        public int? ActiveHtVpdNums { get; set; }

        /// <summary>
        /// Gets or Sets the active lt vpd nums.
        /// </summary>
        [JsonPropertyName("activeLtVpdNums")]
        public int? ActiveLtVpdNums { get; set; }

        /// <summary>
        /// Gets or Sets the target T switch.
        /// </summary>
        [JsonPropertyName("targetTSwitch")]
        public int? TargetTSwitch { get; set; }

        /// <summary>
        /// Gets or Sets the target humi switch.
        /// </summary>
        [JsonPropertyName("targetHumiSwitch")]
        public int? TargetHumiSwitch { get; set; }

        /// <summary>
        /// Gets or Sets the setting mode.
        /// </summary>
        [JsonPropertyName("settingMode")]
        public int? SettingMode { get; set; }

        /// <summary>
        /// Gets or Sets the vpd setting mode.
        /// </summary>
        [JsonPropertyName("vpdSettingMode")]
        public int? VpdSettingMode { get; set; }

        /// <summary>
        /// Gets or Sets the target vpd switch.
        /// </summary>
        [JsonPropertyName("targetVpdSwitch")]
        public int? TargetVpdSwitch { get; set; }

        /// <summary>
        /// Gets or Sets the target vpd.
        /// </summary>
        [JsonPropertyName("targetVpd")]
        public int? TargetVpd { get; set; }

        /// <summary>
        /// Gets or Sets the target temp.
        /// </summary>
        [JsonPropertyName("targetTemp")]
        public int? TargetTemp { get; set; }

        /// <summary>
        /// Gets or Sets the target temp F.
        /// </summary>
        [JsonPropertyName("targetTempF")]
        public int? TargetTempF { get; set; }

        /// <summary>
        /// Gets or Sets the target humi.
        /// </summary>
        [JsonPropertyName("targetHumi")]
        public int? TargetHumi { get; set; }

        /// <summary>
        /// Gets or Sets a value indicating whether update vpd is nums.
        /// </summary>
        [JsonPropertyName("isUpdateVpdNums")]
        public bool IsUpdateVpdNums { get; set; }

        /// <summary>
        /// Gets or Sets the co2 target switch.
        /// </summary>
        [JsonPropertyName("co2TargetSwitch")]
        public int? Co2TargetSwitch { get; set; }

        /// <summary>
        /// Gets or Sets the co2 setting mode.
        /// </summary>
        [JsonPropertyName("co2SettingMode")]
        public int? Co2SettingMode { get; set; }

        /// <summary>
        /// Gets or Sets the co2 high switch.
        /// </summary>
        [JsonPropertyName("co2HighSwitch")]
        public int? Co2HighSwitch { get; set; }

        /// <summary>
        /// Gets or Sets the co2 low switch.
        /// </summary>
        [JsonPropertyName("co2LowSwitch")]
        public int? Co2LowSwitch { get; set; }

        /// <summary>
        /// Gets or Sets the co2 high value.
        /// </summary>
        [JsonPropertyName("co2HighValue")]
        public int? Co2HighValue { get; set; }

        /// <summary>
        /// Gets or Sets the co2 low value.
        /// </summary>
        [JsonPropertyName("co2LowValue")]
        public int? Co2LowValue { get; set; }

        /// <summary>
        /// Gets or Sets the co2 target value.
        /// </summary>
        [JsonPropertyName("co2TargetValue")]
        public int? Co2TargetValue { get; set; }

        /// <summary>
        /// Gets or Sets the co2 fan target switch.
        /// </summary>
        [JsonPropertyName("co2FanTargetSwitch")]
        public int? Co2FanTargetSwitch { get; set; }

        /// <summary>
        /// Gets or Sets the co2 fan setting mode.
        /// </summary>
        [JsonPropertyName("co2FanSettingMode")]
        public int? Co2FanSettingMode { get; set; }

        /// <summary>
        /// Gets or Sets the co2 fan high switch.
        /// </summary>
        [JsonPropertyName("co2FanHighSwitch")]
        public int? Co2FanHighSwitch { get; set; }

        /// <summary>
        /// Gets or Sets the co2 fan low switch.
        /// </summary>
        [JsonPropertyName("co2FanLowSwitch")]
        public int? Co2FanLowSwitch { get; set; }

        /// <summary>
        /// Gets or Sets the co2 fan high value.
        /// </summary>
        [JsonPropertyName("co2FanHighValue")]
        public int? Co2FanHighValue { get; set; }

        /// <summary>
        /// Gets or Sets the co2 fan low value.
        /// </summary>
        [JsonPropertyName("co2FanLowValue")]
        public int? Co2FanLowValue { get; set; }

        /// <summary>
        /// Gets or Sets the co2 fan target value.
        /// </summary>
        [JsonPropertyName("co2FanTargetValue")]
        public int? Co2FanTargetValue { get; set; }

        /// <summary>
        /// Gets or Sets the moisture target switch.
        /// </summary>
        [JsonPropertyName("moistureTargetSwitch")]
        public int? MoistureTargetSwitch { get; set; }

        /// <summary>
        /// Gets or Sets the moisture setting mode.
        /// </summary>
        [JsonPropertyName("moistureSettingMode")]
        public int? MoistureSettingMode { get; set; }

        /// <summary>
        /// Gets or Sets the moisture high switch.
        /// </summary>
        [JsonPropertyName("moistureHighSwitch")]
        public int? MoistureHighSwitch { get; set; }

        /// <summary>
        /// Gets or Sets the moisture low switch.
        /// </summary>
        [JsonPropertyName("moistureLowSwitch")]
        public int? MoistureLowSwitch { get; set; }

        /// <summary>
        /// Gets or Sets the moisture high value.
        /// </summary>
        [JsonPropertyName("moistureHighValue")]
        public int? MoistureHighValue { get; set; }

        /// <summary>
        /// Gets or Sets the moisture low value.
        /// </summary>
        [JsonPropertyName("moistureLowValue")]
        public int? MoistureLowValue { get; set; }

        /// <summary>
        /// Gets or Sets the moisture target value.
        /// </summary>
        [JsonPropertyName("moistureTargetValue")]
        public int? MoistureTargetValue { get; set; }

        /// <summary>
        /// Gets or Sets the water temp target switch.
        /// </summary>
        [JsonPropertyName("waterTempTargetSwitch")]
        public int? WaterTempTargetSwitch { get; set; }

        /// <summary>
        /// Gets or Sets the water temp setting mode.
        /// </summary>
        [JsonPropertyName("waterTempSettingMode")]
        public int? WaterTempSettingMode { get; set; }

        /// <summary>
        /// Gets or Sets the water temp high switch.
        /// </summary>
        [JsonPropertyName("waterTempHighSwitch")]
        public int? WaterTempHighSwitch { get; set; }

        /// <summary>
        /// Gets or Sets the water temp low switch.
        /// </summary>
        [JsonPropertyName("waterTempLowSwitch")]
        public int? WaterTempLowSwitch { get; set; }

        /// <summary>
        /// Gets or Sets the water temp high value F.
        /// </summary>
        [JsonPropertyName("waterTempHighValueF")]
        public int? WaterTempHighValueF { get; set; }

        /// <summary>
        /// Gets or Sets the water temp high value.
        /// </summary>
        [JsonPropertyName("waterTempHighValue")]
        public int? WaterTempHighValue { get; set; }

        /// <summary>
        /// Gets or Sets the water temp low value F.
        /// </summary>
        [JsonPropertyName("waterTempLowValueF")]
        public int? WaterTempLowValueF { get; set; }

        /// <summary>
        /// Gets or Sets the water temp low value.
        /// </summary>
        [JsonPropertyName("waterTempLowValue")]
        public int? WaterTempLowValue { get; set; }

        /// <summary>
        /// Gets or Sets the water temp target value F.
        /// </summary>
        [JsonPropertyName("waterTempTargetValueF")]
        public int? WaterTempTargetValueF { get; set; }

        /// <summary>
        /// Gets or Sets the water temp target value.
        /// </summary>
        [JsonPropertyName("waterTempTargetValue")]
        public int? WaterTempTargetValue { get; set; }

        /// <summary>
        /// Gets or Sets the ph target switch.
        /// </summary>
        [JsonPropertyName("phTargetSwitch")]
        public int? PhTargetSwitch { get; set; }

        /// <summary>
        /// Gets or Sets the ph setting mode.
        /// </summary>
        [JsonPropertyName("phSettingMode")]
        public int? PhSettingMode { get; set; }

        /// <summary>
        /// Gets or Sets the ph high switch.
        /// </summary>
        [JsonPropertyName("phHighSwitch")]
        public int? PhHighSwitch { get; set; }

        /// <summary>
        /// Gets or Sets the ph low switch.
        /// </summary>
        [JsonPropertyName("phLowSwitch")]
        public int? PhLowSwitch { get; set; }

        /// <summary>
        /// Gets or Sets the ph high value.
        /// </summary>
        [JsonPropertyName("phHighValue")]
        public int? PhHighValue { get; set; }

        /// <summary>
        /// Gets or Sets the ph low value.
        /// </summary>
        [JsonPropertyName("phLowValue")]
        public int? PhLowValue { get; set; }

        /// <summary>
        /// Gets or Sets the ph target value.
        /// </summary>
        [JsonPropertyName("phTargetValue")]
        public int? PhTargetValue { get; set; }

        /// <summary>
        /// Gets or Sets the ec tds target switch.
        /// </summary>
        [JsonPropertyName("ecTdsTargetSwitch")]
        public int? EcTdsTargetSwitch { get; set; }

        /// <summary>
        /// Gets or Sets the ec tds setting mode.
        /// </summary>
        [JsonPropertyName("ecTdsSettingMode")]
        public int? EcTdsSettingMode { get; set; }

        /// <summary>
        /// Gets or Sets the ec tds high switch.
        /// </summary>
        [JsonPropertyName("ecTdsHighSwitch")]
        public int? EcTdsHighSwitch { get; set; }

        /// <summary>
        /// Gets or Sets the ec tds low switch.
        /// </summary>
        [JsonPropertyName("ecTdsLowSwitch")]
        public int? EcTdsLowSwitch { get; set; }

        /// <summary>
        /// Gets or Sets the ec tds high value ec.
        /// </summary>
        [JsonPropertyName("ecTdsHighValueEc")]
        public int? EcTdsHighValueEc { get; set; }

        /// <summary>
        /// Gets or Sets the ec tds high value tds.
        /// </summary>
        [JsonPropertyName("ecTdsHighValueTds")]
        public int? EcTdsHighValueTds { get; set; }

        /// <summary>
        /// Gets or Sets the ec tds low value ec.
        /// </summary>
        [JsonPropertyName("ecTdsLowValueEc")]
        public int? EcTdsLowValueEc { get; set; }

        /// <summary>
        /// Gets or Sets the ec tds low value tds.
        /// </summary>
        [JsonPropertyName("ecTdsLowValueTds")]
        public int? EcTdsLowValueTds { get; set; }

        /// <summary>
        /// Gets or Sets the ec tds target value ec.
        /// </summary>
        [JsonPropertyName("ecTdsTargetValueEc")]
        public int? EcTdsTargetValueEc { get; set; }

        /// <summary>
        /// Gets or Sets the ec tds target value tds.
        /// </summary>
        [JsonPropertyName("ecTdsTargetValueTds")]
        public int? EcTdsTargetValueTds { get; set; }

        /// <summary>
        /// Gets or Sets the humidity.
        /// </summary>
        [JsonPropertyName("humidity")]
        public int? Humidity { get; set; }

        /// <summary>
        /// Gets or Sets the temperature.
        /// </summary>
        [JsonPropertyName("temperature")]
        public int? Temperature { get; set; }

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
        /// Gets or Sets the at type.
        /// </summary>
        [JsonPropertyName("atType")]
        public int? AtType { get; set; }

        /// <summary>
        /// Gets or Sets the temperature F.
        /// </summary>
        [JsonPropertyName("temperatureF")]
        public int? TemperatureF { get; set; }

        /// <summary>
        /// Gets or Sets the is open automation.
        /// </summary>
        [JsonPropertyName("isOpenAutomation")]
        public int? IsOpenAutomation { get; set; }

        /// <summary>
        /// Gets or Sets the dev time zone.
        /// </summary>
        [JsonPropertyName("devTimeZone")]
        public string DevTimeZone { get; set; } = string.Empty;

        /// <summary>
        /// Gets or Sets the dev setting.
        /// </summary>
        [JsonPropertyName("devSetting")]
        public DeviceSettings DevSetting { get; set; } = default!;

        /// <summary>
        /// Gets or Sets the load type.
        /// </summary>
        [JsonPropertyName("loadType")]
        public int? LoadType { get; set; }

        /// <summary>
        /// Gets or Sets the load state.
        /// </summary>
        [JsonPropertyName("loadState")]
        public int? LoadState { get; set; }

        /// <summary>
        /// Gets or Sets the abnormal state.
        /// </summary>
        [JsonPropertyName("abnormalState")]
        public int? AbnormalState { get; set; }

        /// <summary>
        /// Gets or Sets the dev mac addr.
        /// </summary>
        [JsonPropertyName("devMacAddr")]
        public string? DevMacAddr { get; set; }

        /// <summary>
        /// Gets or Sets a value indicating whether restore.
        /// </summary>
        [JsonPropertyName("restore")]
        public bool Restore { get; set; }

        /// <summary>
        /// Gets or Sets the master port.
        /// </summary>
        [JsonPropertyName("masterPort")]
        public int? MasterPort { get; set; }

        /// <summary>
        /// Gets or Sets the only update speed.
        /// </summary>
        [JsonPropertyName("onlyUpdateSpeed")]
        public int? OnlyUpdateSpeed { get; set; }
    }
}
