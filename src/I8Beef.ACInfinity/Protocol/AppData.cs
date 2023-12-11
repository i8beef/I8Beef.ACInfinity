using System.Text.Json.Serialization;

namespace I8Beef.ACInfinity.Protocol
{
    /// <summary>
    /// App data response.
    /// </summary>
    public class AppData
    {
        /// <summary>
        /// App id.
        /// </summary>
        [JsonPropertyName("appId")]
        public string AppId { get; set; } = string.Empty;

        /// <summary>
        /// Nickname.
        /// </summary>
        [JsonPropertyName("nickName")]
        public string NickName { get; set; } = string.Empty;

        /// <summary>
        /// App email.
        /// </summary>
        [JsonPropertyName("appEmail")]
        public string AppEmail { get; set; } = string.Empty;

        /// <summary>
        /// App password L?
        /// </summary>
        [JsonPropertyName("appPasswordl")]
        public string AppPasswordL { get; set; } = string.Empty;

        /// <summary>
        /// Indicates if app is usable.
        /// </summary>
        [JsonPropertyName("appUsable")]
        public int AppUsable { get; set; }

        /// <summary>
        /// Indicates if forum is usable.
        /// </summary>
        [JsonPropertyName("forumUsable")]
        public int ForumUsable { get; set; }

        /// <summary>
        /// Forum role.
        /// </summary>
        [JsonPropertyName("forumRole")]
        public int ForumRole { get; set; }

        /// <summary>
        /// App create time.
        /// </summary>
        [JsonPropertyName("appCreateTime")]
        public string AppCreateTime { get; set; } = string.Empty;

        /// <summary>
        /// Indicates if app is analytics.
        /// </summary>
        [JsonPropertyName("appIsanalytics")]
        public int AppIsAnalytics { get; set; }

        /// <summary>
        /// Indicates if app is big repost.
        /// </summary>
        [JsonPropertyName("appIsbugreport")]
        public int AppIsBugReport { get; set; }

        /// <summary>
        /// Indicates if app is email repost.
        /// </summary>
        [JsonPropertyName("appIsemailrepost")]
        public int AppIsEmailRepost { get; set; }

        /// <summary>
        /// App create time.
        /// </summary>
        [JsonPropertyName("createTime")]
        public string? CreateTime { get; set; }
    }
}
