using System.Collections.Generic;
using TheCrushinator.XamarinFormly.FormElements;
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

            var fields = JsonResourceHelpers.ResourceToModel<List<Field>>("LargeFormly.json");

            var items = new List<View>();
            foreach (var field in fields)
            {
                items.Add(new FormInput());
            }

            StackLayout.Children.Clear();
            items.ForEach(x => StackLayout.Children.Add(x));
        }
    }
}
