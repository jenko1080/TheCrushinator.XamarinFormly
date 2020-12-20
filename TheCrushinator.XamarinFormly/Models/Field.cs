namespace TheCrushinator.XamarinFormly.Models
{
    public class Field
    {
        public string Key { get; set; }
        public string Type { get; set; }
        public TemplateOptions TemplateOptions { get; set; }
        public Validation Validation { get; set; }
        public ExpressionProperties ExpressionProperties { get; set; }
        public string HideExpression { get; set; }
        public AsyncValidators AsyncValidators { get; set; }
    }
}