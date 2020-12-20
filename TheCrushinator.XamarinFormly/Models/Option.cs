namespace TheCrushinator.XamarinFormly.Models
{
    /// <summary>
    /// Options that can make up SelectOptions within a radio button or select
    /// </summary>
    public class Option
    {
        public int Value { get; set; }
        public string Label { get; set; }
        public bool? Disabled { get; set; }
    }
}
