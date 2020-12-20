using System.Collections.Generic;
using TheCrushinator.XamarinFormly.Models;
using TheCrushinator.XamarinFormly.Utilities;
using Xamarin.Forms;

namespace TheCrushinator.XamarinFormly
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            var stuff = JsonResourceHelpers.ResourceToModel<List<Field>>("LargeFormly.json");

            var x = new Label();
        }
    }
}
