using System.Collections.Generic;

namespace TheCrushinator.XamarinFormly.Models
{
    public class TemplateOptions
    {
        public string Label { get; set; }
        public string Placeholder { get; set; }
        public string Description { get; set; }
        public bool Required { get; set; }
        public string Pattern { get; set; }
        public List<Option> Options { get; set; }
        public string Type { get; set; }
        public int? Min { get; set; }
        public int? Max { get; set; }
        public int? MinLength { get; set; }
        public int? MaxLength { get; set; }
        public int? Rows { get; set; }
    }
}
