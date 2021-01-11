using System.Text.Json.Serialization;

namespace TheCrushinator.XamarinFormly.Models
{
    public class Validation
    {
        [JsonPropertyName("messages")]
        public Messages Messages { get; set; }
    }
}
