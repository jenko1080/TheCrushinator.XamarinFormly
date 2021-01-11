using System.Text.Json.Serialization;

namespace TheCrushinator.XamarinFormly.Models
{
    public class Messages
    {
        [JsonPropertyName("pattern")]
        public string Pattern { get; set; }
    }
}
