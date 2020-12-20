using System.Collections.Generic;

namespace TheCrushinator.XamarinFormly.Models
{
    /// <summary>
    /// A complete form, schema and data
    /// </summary>
    public class Form
    {
        public ICollection<Field> Fields { get; set; }

        /// <summary>
        /// JSON string of the data that goes in the matching strings.
        /// </summary>
        public string Data { get; set; }
    }
}
