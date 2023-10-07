using Newtonsoft.Json;

namespace FalconNL93.HADotNet.Models
{
    /// <summary>
    /// Represents the automation result.
    /// </summary>
    public class AutomationResultObject
    {
        /// <summary>
        /// Gets or sets the automation result.
        /// </summary>
        [JsonProperty("result")]
        public string Result { get; set; }
    }
}
