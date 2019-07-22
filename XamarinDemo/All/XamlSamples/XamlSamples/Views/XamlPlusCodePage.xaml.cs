using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamlSamples.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class XamlPlusCodePage : ContentPage
    {
        public XamlPlusCodePage()
        {
            InitializeComponent();
        }

        private void OnSliderValueChanged(object sender, ValueChangedEventArgs e)
        {
            valueLabel.Text = e.NewValue.ToString("F3");
        }

        private async void OnButtonClickedAsync(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            await DisplayAlert("Clicked!", "The button labeled '" + button.Text + "' has been clicked", "OK");
        }
    }
}