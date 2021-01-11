using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace TheCrushinator.XamarinFormly.Models
{
    public class TemplateOptions
    {
        [JsonPropertyName("label")]
        public string Label { get; set; }

        [JsonPropertyName("placeholder")]
        public string Placeholder { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("required")]
        public bool Required { get; set; }

        [JsonPropertyName("pattern")]
        public string Pattern { get; set; }

        [JsonPropertyName("options")]
        public List<Option> Options { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("min")]
        public int? Min { get; set; }

        [JsonPropertyName("max")]
        public int? Max { get; set; }

        [JsonPropertyName("minLength")]
        public int? MinLength { get; set; }

        [JsonPropertyName("maxLength")]
        public int? MaxLength { get; set; }

        [JsonPropertyName("rows")]
        public int? Rows { get; set; }
    }
}
