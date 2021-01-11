using System.Text.Json.Serialization;

namespace TheCrushinator.XamarinFormly.Models
{
    public class Field
    {
        [JsonPropertyName("key")]
        public string Key { get; set; }
        
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("templateOptions")]
        public TemplateOptions TemplateOptions { get; set; }

        [JsonPropertyName("validation")]
        public Validation Validation { get; set; }

        [JsonPropertyName("expressionProperties")]
        public ExpressionProperties ExpressionProperties { get; set; }

        [JsonPropertyName("hideExpression")]
        public string HideExpression { get; set; }

        [JsonPropertyName("asyncValidators")]
        public AsyncValidators AsyncValidators { get; set; }
    }
}