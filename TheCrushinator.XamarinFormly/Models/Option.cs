using System.Text.Json.Serialization;

namespace TheCrushinator.XamarinFormly.Models
{
    /// <summary>
    /// Options that can make up SelectOptions within a radio button or select
    /// </summary>
    public class Option
    {
        [JsonPropertyName("value")]
        public int Value { get; set; }

        [JsonPropertyName("label")]
        public string Label { get; set; }

        [JsonPropertyName("disabled")]
        public bool? Disabled { get; set; }
    }
}
