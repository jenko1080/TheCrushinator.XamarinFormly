using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace TheCrushinator.XamarinFormly.Models
{
    /// <summary>
    /// A complete form, schema and data
    /// </summary>
    public class Form
    {
        [JsonPropertyName("fields")]
        public ICollection<Field> Fields { get; set; }

        /// <summary>
        /// JSON string of the data that goes in the matching strings.
        /// </summary>
        [JsonPropertyName("data")]
        public string Data { get; set; }
    }
}
