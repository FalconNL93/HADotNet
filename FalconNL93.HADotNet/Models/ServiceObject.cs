using System.Collections.Generic;

namespace FalconNL93.HADotNet.Models
{
    /// <summary>
    /// Represents a signle service definition.
    /// </summary>
    public class ServiceObject
    {
        /// <summary>
        /// The description of the service object.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The fields/parameters that the service supports.
        /// </summary>
        public Dictionary<string, ServiceFieldObject> Fields { get; set; }
    }
}
